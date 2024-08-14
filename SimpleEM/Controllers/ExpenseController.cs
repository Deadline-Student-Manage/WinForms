using Newtonsoft.Json;
using SimpleEM.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleEM.Controllers
{
    public class ExpenseController
    {
        private List<Expenses> expenses = new List<Expenses>();
        private Dictionary<string, decimal> categoryBudgets = new Dictionary<string, decimal>();
        private HashSet<string> alertedCategories = new HashSet<string>(); // Tập hợp lưu trữ các danh mục đã cảnh báo

        public List<Expenses> GetExpenses()
        {
            return expenses;
        }

        public void AddExpense(Expenses expense)
        {
            // Thêm chi tiêu nếu không trùng lặp
            if (!expenses.Any(e => e.GetDescription() == expense.GetDescription() && e.GetAmount() == expense.GetAmount() && e.GetDate() == expense.GetDate() && e.GetCategory() == expense.GetCategory()))
            {
                expenses.Add(expense);

                // Kiểm tra ngân sách danh mục
                string category = expense.GetCategory();
                decimal totalAmountInCategory = GetTotalAmountByCategory(category);
                decimal categoryBudget = GetCategoryBudget(category);

                // Nếu tổng chi tiêu vượt ngân sách và chưa cảnh báo cho danh mục này
                if (totalAmountInCategory > categoryBudget && !alertedCategories.Contains(category))
                {
                    Console.WriteLine($"Warning: You have exceeded the budget for category '{category}'!");
                    alertedCategories.Add(category); // Thêm danh mục vào danh sách đã cảnh báo
                }
            }
        }

        public void RemoveExpense(Expenses expense)
        {
            var existingExpense = expenses.FirstOrDefault(e => e.GetDescription() == expense.GetDescription() && e.GetAmount() == expense.GetAmount() && e.GetDate() == expense.GetDate() && e.GetCategory() == expense.GetCategory());
            if (existingExpense != null)
            {
                expenses.Remove(existingExpense);

                // Kiểm tra lại trạng thái cảnh báo cho danh mục sau khi xóa chi tiêu
                string category = existingExpense.GetCategory();
                decimal totalAmountInCategory = GetTotalAmountByCategory(category);
                decimal categoryBudget = GetCategoryBudget(category);

                if (totalAmountInCategory <= categoryBudget && alertedCategories.Contains(category))
                {
                    alertedCategories.Remove(category); // Reset cảnh báo nếu không còn vượt ngân sách
                }
            }
        }

        public decimal GetTotalAmount()
        {
            return expenses.Sum(expense => expense.GetAmount());
        }

        public decimal GetCategoryBudget(string category)
        {
            return categoryBudgets.ContainsKey(category) ? categoryBudgets[category] : 0;
        }

        public void SetCategoryBudget(string category, decimal budget)
        {
            categoryBudgets[category] = budget;
            // Reset cảnh báo khi cập nhật ngân sách
            if (alertedCategories.Contains(category))
            {
                alertedCategories.Remove(category);
            }
        }

        public void RemoveCategoryBudget(string category)
        {
            if (categoryBudgets.ContainsKey(category))
            {
                categoryBudgets.Remove(category);
            }
        }
        public decimal GetTotalAmountByCategory(string category)
        {
            return expenses.Where(expense => expense.GetCategory() == category).Sum(expense => expense.GetAmount());
        }

        public void SaveData(string filePath)
        {
            var data = new
            {
                Expenses = expenses.Select(exp => new
                {
                    Description = exp.GetDescription(),
                    Amount = exp.GetAmount(),
                    Date = exp.GetDate(),
                    Category = exp.GetCategory()
                }).ToList(),
                CategoryBudgets = categoryBudgets
            };

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void LoadData(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var data = JsonConvert.DeserializeObject<dynamic>(json);

                expenses.Clear();
                categoryBudgets.Clear();

                foreach (var exp in data.Expenses)
                {
                    if (exp != null && exp.Description != null && exp.Amount != null && exp.Date != null && exp.Category != null)
                    {
                        Expenses newExpense = new Expenses();
                        newExpense.SetDescription(exp.Description.ToString());
                        newExpense.SetAmount((decimal)exp.Amount);
                        newExpense.SetDate((DateTime)exp.Date);
                        newExpense.SetCategory(exp.Category.ToString());
                        expenses.Add(newExpense);
                    }
                }

                var budgets = data.CategoryBudgets.ToObject<Dictionary<string, decimal>>();
                foreach (var budget in budgets)
                {
                    categoryBudgets[budget.Key] = budget.Value;
                }
            }
        }

        public Dictionary<string, decimal> GetCategoryBudgets()
        {
            return new Dictionary<string, decimal>(categoryBudgets);
        }
    }
}
