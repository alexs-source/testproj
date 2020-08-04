using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testproj.Utils;

namespace testproj.Controllers
{
    public class DashboardController : Controller
    {
        ISingleton repo;
        public DashboardController(ISingleton repo)
        {
            this.repo = repo;
        }
        public IActionResult Dashboard()
        {
            //ViewBag.LastVisited = GetLastVisited();
            return View();
        }

        //private LastVisited[] GetLastVisited()
        //{
        //    var lastVisited = repo.GetLastVisited();

        //    return lastVisited;
        //}
    }
}
