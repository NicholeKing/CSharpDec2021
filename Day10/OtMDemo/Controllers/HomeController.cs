using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtMDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace OtMDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Old call:
            // ViewBag.AllTeachers = _context.Teachers.ToList();
            ViewBag.AllTeachers = _context.Teachers.Include(a => a.MyStudents).ToList();
            return View();
        }

        [HttpPost("addTeacher")]
        public IActionResult addTeacher(Teacher newTeacher)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newTeacher);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                ViewBag.AllTeachers = _context.Teachers.Include(a => a.MyStudents).ToList();
                return View("Index");
            }
        }

        [HttpPost("addStudent")]
        public IActionResult addStudent(Student newStudent)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                ViewBag.AllTeachers = _context.Teachers.Include(a => a.MyStudents).ToList();
                return View("Index");
            }
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
