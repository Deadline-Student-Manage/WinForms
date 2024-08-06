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

        public List<Expenses> GetExpenses()
        {
            return expenses;
        }

        public void AddExpense(Expenses expense)
        {
            if (!expenses.Any(e => e.GetDescription() == expense.GetDescription() && e.GetAmount() == expense.GetAmount() && e.GetDate() == expense.GetDate() && e.GetCategory() == expense.GetCategory()))
            {
                expenses.Add(expense);
            }
        }

        public void RemoveExpense(Expenses expense)
        {
            var existingExpense = expenses.FirstOrDefault(e => e.GetDescription() == expense.GetDescription() && e.GetAmount() == expense.GetAmount() && e.GetDate() == expense.GetDate() && e.GetCategory() == expense.GetCategory());
            if (existingExpense != null)
            {
                expenses.Remove(existingExpense);
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
