using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testproj.Models;

namespace testproj.Utils
{
    public class Repository : ISingleton
    {
        public Storage[] GetStorages()
        {
            return new Storage[]
            {
                new Storage() {Id = 1, Name = "First Storage", Items = new List<Item>()
                    {
                        new Item() {Id = 1, Name = "Sugar", Amount = 1, Units=UnitsEnum.kg},
                        new Item() {Id = 2, Name = "Milk", Amount = 1, Units=UnitsEnum.l},

                    }
                },
                new Storage() {Id = 1, Name = "Second Storage", Items = new List<Item>()
                    {
                        new Item() {Id = 3, Name = "Apples", Amount = 10, Units=UnitsEnum.piece},
                        new Item() {Id = 3, Name = "Salt", Amount = 50, Units=UnitsEnum.g},

                    }
                },
            };
        }


        public LastVisited[] GetLastVisited()
        {
            return new LastVisited[]
            {
                new LastVisited()
                {
                    Id = Guid.NewGuid(),
                    Name = "First Storage",
                    LastVisitedDateTime = DateTime.Now
                },
                new LastVisited()
                {
                    Id = Guid.NewGuid(),
                    Name = "Second Storage",
                    LastVisitedDateTime = DateTime.Now
                },                
                new LastVisited()
                {
                    Id = Guid.NewGuid(),
                    Name = "Shopping List",
                    LastVisitedDateTime = DateTime.Now
                },
            };
        }
    }
}
