using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using testproj.Utils;

namespace testproj.Controllers
{
    public class StorageController : Controller
    {
        private ISingleton repo;
        public StorageController(ISingleton repo)
        {
            this.repo = repo;
        }
        public IActionResult Storage()
        {
            return View();
        }

        public IActionResult Storages()
        {
            var storages = repo.GetStorages();
            ViewBag.StorageNames = storages.Select(s => s.Name);
            return View();
        }
    }
}
