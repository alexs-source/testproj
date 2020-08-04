using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testproj.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; } = "user";
    }
}
