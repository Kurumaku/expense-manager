using System;
using System.Collections.Generic;
using System.Text;

namespace manaherUI
{
    public class Expense
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public DateTime Time { get; set; }
        public int Piece { get; set; }
        public string Category { get; set; } = "";
    }
}
