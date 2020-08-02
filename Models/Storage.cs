using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testproj.Models
{
    public class Storage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Item> Items { get; set; }
    }
}
