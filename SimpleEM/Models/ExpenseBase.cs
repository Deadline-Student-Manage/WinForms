// Models/ExpenseBase.cs
using System;
using System.Collections.Generic;

namespace SimpleEM.Models
{
    public abstract class ExpenseBase
    {
        private string? description;
        private decimal amount;
        private DateTime date;

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

        public abstract decimal GetCategoryBudget(string category);
        public abstract void SetCategoryBudget(string category, decimal budget);
    }
}
