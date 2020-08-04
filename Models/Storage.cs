﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testproj.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Type { get; } = "storage";
        public string Name { get; set; }

        public List<Item> Items { get; set; }
    }
}
