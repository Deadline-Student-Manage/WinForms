// Models/Expense.cs
using System.Collections.Generic;

namespace SimpleEM.Models
{
    public class Expenses : ExpenseBase
    {
        private Dictionary<string, decimal> categoryBudgets = new Dictionary<string, decimal>();
        private string? _category;
        internal string? Description;
        internal decimal Amount;
        internal DateTime Date;
        internal string? Category;

        public string GetCategory()
        {
            return _category;
        }

        public void SetCategory(string value)
        {
            _category = value;
        }

        public override string ToString()
        {
            return $"{GetDescription()} ({GetCategory()}): {GetAmount()} VNĐ - {GetDate().ToShortDateString()}";
        }

        public override decimal GetCategoryBudget(string category)
        {
            if (categoryBudgets.TryGetValue(category, out decimal budget))
            {
                return budget;
            }
            return 0;
        }

        public override void SetCategoryBudget(string category, decimal budget)
        {
            if (categoryBudgets.ContainsKey(category))
            {
                categoryBudgets[category] = budget;
            }
            else
            {
                categoryBudgets.Add(category, budget);
            }
        }
        public void RemoveCategoryBudget(string category)
        {
            if (categoryBudgets.ContainsKey(category))
            {
                categoryBudgets.Remove(category);
            }
        }

    }
}
