// Models/Expenses.cs
using System;
using System.Collections.Generic;

namespace SimpleEM.Models
{
    public class Expenses
    {
        // Thuộc tính chi tiêu
        private string? description;
        private decimal amount;
        private DateTime date;
        private string? _category;

        // Từ điển quản lý ngân sách theo danh mục
        private Dictionary<string, decimal> categoryBudgets = new Dictionary<string, decimal>();

        // Các phương thức getter và setter cho chi tiêu
        public string? GetDescription()
        {
            return description;
        }

        public void SetDescription(string? value)
        {
            description = value;
        }

        public decimal GetAmount()
        {
            return amount;
        }

        public void SetAmount(decimal value)
        {
            amount = value;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public void SetDate(DateTime value)
        {
            date = value;
        }

        // Phương thức cho danh mục
        public string GetCategory()
        {
            return _category;
        }

        public void SetCategory(string value)
        {
            _category = value;
        }

        // Phương thức quản lý ngân sách cho từng danh mục
        public decimal GetCategoryBudget(string category)
        {
            if (categoryBudgets.TryGetValue(category, out decimal budget))
            {
                return budget;
            }
            return 0;
        }

        public void SetCategoryBudget(string category, decimal budget)
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

        // Phương thức để hiển thị chi tiêu dưới dạng chuỗi
        public override string ToString()
        {
            return $"{GetDescription()} ({GetCategory()}): {GetAmount()} VNĐ - {GetDate().ToShortDateString()}";
        }
    }
}
