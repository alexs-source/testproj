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
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public UnitsEnum Units { get; set; }
    }
}
