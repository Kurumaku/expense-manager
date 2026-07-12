using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace manaherUI
{
    public class ExpenseManager
    {
        private List<Expense> expenses;
        private ExpenseStorage storage;
        public decimal BudgetLimit { get; set; }

        public ExpenseManager(string filePath)
        {
            storage = new ExpenseStorage(filePath);
            expenses = storage.Load();
        }

        public List<Expense> GetAll()
        {
            return expenses;
        }
        public void Update(Expense oldItem, Expense newItem) // метод для обновления
        {
            int index = expenses.IndexOf(oldItem);
            expenses[index] = newItem;
            storage.Save(expenses);
        }
        public void Add(Expense item)
        {
            expenses.Add(item);
            storage.Save(expenses);
        }

        public void Remove(Expense item)
        {
            expenses.Remove(item);
            storage.Save(expenses);
        }

        public List<Expense> Filter(string category)
        {
            if (category == "all") return expenses;
            return expenses.Where(ex => ex.Category == category).ToList();
        }

        public decimal GetTotal(List<Expense> list)
        {
            return list.Sum(ex => ex.Price);
        }
    }
}