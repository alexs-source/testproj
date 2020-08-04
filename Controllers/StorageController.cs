using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using testproj.Models;
using testproj.Utils;

namespace testproj.Controllers
{
    public class StorageController : Controller
    {
        private Repository repo;
        public StorageController(ISingleton repo)
        {
            this.repo = repo as Repository;
        }
        public IActionResult Storage()
        {
            return View();
        }

        public async Task<IActionResult> Storages()
        {
            var storages = await repo.GetStoragesByUserIdAsync(1);
            ViewBag.StorageNames = storages.Select(s => s.Name);
            return View();
        }

        public IActionResult PostStorage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostStorage([FromForm] string StorageName)
        {
            await repo.AddStorageAsync(new Storage() { 
                Name = StorageName,
                StorageId = "1",
                UserId = "1",
                Id = "1"
            });
            return View();
        }
    }
}
