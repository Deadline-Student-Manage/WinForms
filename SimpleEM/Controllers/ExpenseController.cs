// Controllers/ExpenseController.cs
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
            var expense = expenses.FirstOrDefault(e => e.GetCategory() == category);
            return expense?.GetCategoryBudget(category) ?? 0;
        }

        public void SetCategoryBudget(string category, decimal budget)
        {
            var existingExpense = expenses.FirstOrDefault(expense => expense.GetCategory() == category);

            if (existingExpense != null)
            {
                existingExpense.SetCategoryBudget(category, budget);
            }
            else
            {
                // Thêm danh mục mới vào danh sách ngân sách mà không thêm chi tiêu rác
                var tempExpense = new Expenses();
                tempExpense.SetCategory(category);
                tempExpense.SetCategoryBudget(category, budget);
                expenses.Add(tempExpense);
            }
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
                CategoryBudgets = expenses
                    .SelectMany(exp => exp.GetType().GetField("categoryBudgets", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .GetValue(exp) as Dictionary<string, decimal>)
                    .GroupBy(kvp => kvp.Key)
                    .ToDictionary(group => group.Key, group => group.First().Value)
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

                var categoryBudgets = data.CategoryBudgets.ToObject<Dictionary<string, decimal>>();
                foreach (var budget in categoryBudgets)
                {
                    SetCategoryBudget(budget.Key, budget.Value);
                }
            }
        }




        public void RemoveCategoryBudget(string category)
        {
            foreach (var expense in expenses)
            {
                expense.RemoveCategoryBudget(category);
            }
        }
    }
}
