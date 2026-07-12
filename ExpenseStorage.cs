using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace manaherUI
{
    public class ExpenseStorage
    {
        private string filePath;

        public ExpenseStorage(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Expense> Load()
        {
            List<Expense> result = new List<Expense>();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] fields = line.Split(';');
                    Expense loaded = new Expense();
                    loaded.Name = fields[0];
                    loaded.Price = decimal.Parse(fields[1]);
                    loaded.Category = fields[2];
                    loaded.Time = DateTime.Parse(fields[3]);
                    loaded.Piece = int.Parse(fields[4]);
                    result.Add(loaded);
                }
            }
            return result;
        }

        public void Save(List<Expense> expenses)
        {
            List<string> lines = new List<string>();
            foreach (Expense ex in expenses)
            {
                lines.Add(ex.Name + ";" + ex.Price + ";" + ex.Category + ";" + ex.Time + ";" + ex.Piece);
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}