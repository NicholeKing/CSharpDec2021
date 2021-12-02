using System;
using Microsoft.AspNetCore.Mvc;

namespace formsDemo.Controllers
{
    public class FormController : Controller
    {
        public static string pName;
        public static string pType;

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(string petName, string petType)
        {
            // Console.WriteLine($"Pet Name: {petName} Pet Type: {petType}");
            pName = petName;
            pType = petType;
            return RedirectToAction("Result");
        }

        [HttpGet("Result")]
        public IActionResult Result()
        {
            ViewBag.Name = pName;
            ViewBag.Type = pType;
            return View("Result");
        }

    }
}