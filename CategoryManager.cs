using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace manaherUI
{
    public class CategoryManager
    {
        private string filePath = "categories.txt";
        private List<string> categories;

        public CategoryManager()
        {
            categories = Load();
            if (categories.Count == 0)
            {
                // дефолтные категории при первом запуске
                categories = new List<string> { "food", "transport", "fun", "home", "health", "other" };
                Save();
            }
        }

        public List<string> GetAll()
        {
            return categories.OrderBy(c => c).ToList();
        }

        public List<string> GetAllWithAll()
        {
            List<string> result = new List<string> { "all" };
            result.AddRange(GetAll());
            return result;
        }

        public void Add(string category)
        {
            category = category.Trim();
            if (category == "") return;
            if (categories.Contains(category)) return;
            categories.Add(category);
            Save();
        }

        public bool Remove(string category, List<Expense> allExpenses)
        {
            bool inUse = allExpenses.Any(ex => ex.Category == category);
            if (inUse) return false; // нельзя удалить категорию, если она используется

            categories.Remove(category);
            Save();
            return true;
        }

        private List<string> Load()
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllLines(filePath).ToList();
            }
            return new List<string>();
        }

        private void Save()
        {
            File.WriteAllLines(filePath, categories);
        }
    }
}