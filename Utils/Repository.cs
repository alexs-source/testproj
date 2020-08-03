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
                new Storage() {Id = Guid.NewGuid(), Name = "First Storage", Items = new List<Item>()
                    {
                        new Item() {Id = Guid.NewGuid(), Name = "Sugar", Amount = 1, Units=UnitsEnum.kg},
                        new Item() {Id = Guid.NewGuid(), Name = "Milk", Amount = 1, Units=UnitsEnum.l},

                    }
                },
                new Storage() {Id = Guid.NewGuid(), Name = "Second Storage", Items = new List<Item>()
                    {
                        new Item() {Id = Guid.NewGuid(), Name = "Apples", Amount = 10, Units=UnitsEnum.piece},
                        new Item() {Id = Guid.NewGuid(), Name = "Salt", Amount = 50, Units=UnitsEnum.g},

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
