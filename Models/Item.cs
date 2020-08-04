using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testproj.Models
{
    public enum UnitsEnum
    {
        g, kg, ml, l, piece, 
    }
    public class Item
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public string Type { get; } = "item";
        public UnitsEnum Units { get; set; }
    }
}
