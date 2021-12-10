using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using afternoonSession.Models;
using Microsoft.AspNetCore.Http;

namespace afternoonSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // If a session does not exist
            if(HttpContext.Session.GetInt32("Count") == null)
            {
                // Then make one
                HttpContext.Session.SetInt32("Count", 1);
            } else {
                // Add one to the count
                int? count = (int)HttpContext.Session.GetInt32("Count");
                HttpContext.Session.SetInt32("Count", (int)++count);
            }
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
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
