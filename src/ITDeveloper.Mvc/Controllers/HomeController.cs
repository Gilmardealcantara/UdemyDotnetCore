using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ITDeveloper.Data.ORM;
using ITDeveloper.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITDeveloper.Mvc.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            //var context = new ITDeveloperDbContext(null);
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}