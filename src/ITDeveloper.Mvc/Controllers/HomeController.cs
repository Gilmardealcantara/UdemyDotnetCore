using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ITDeveloper.Mvc.Models;
using ITDeveloper.Data.ORM;

namespace ITDeveloper.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var context = new ITDeveloperDbContext(null);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
