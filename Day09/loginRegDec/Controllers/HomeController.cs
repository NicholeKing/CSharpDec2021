using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using loginRegDec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace loginRegDec.Controllers
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
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                // Validate that the given email isn't already in the database to prevent any future issues with duplicate accounts
                if(_context.Users.Any(u => u.email == newUser.email))
                {
                    ModelState.AddModelError("email", "Email is already in use!");
                    return View("Index");
                }
                // Hash the password only after verifying that everything else is good to go
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.password = Hasher.HashPassword(newUser, newUser.password);
                // Add to the database
                _context.Add(newUser);
                // Don't forget to save your changes
                _context.SaveChanges();
                return RedirectToAction("Success");
            } else {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser logUser)
        {
            if(ModelState.IsValid)
            {
                // Find One user using first or default and the email provided
                User userinDb = _context.Users.FirstOrDefault(u => u.email == logUser.lemail);
                // When we search using first or default if nothing comes back we get null, if something is found we get back a user object
                if(userinDb == null){
                    ModelState.AddModelError("lemail", "Inavlid login attempt");
                    return View("Index");
                }
                // Check if the password is correct
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                //                          var                                            db password      submitted
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userinDb.password, logUser.lpassword);
                // When the verification runs, it will pass back a 1 or a 0 - 1 means successful and 0 means unsuccessful
                if(result == 0)
                {
                    // The password was wrong
                    ModelState.AddModelError("lemail", "Inavlid login attempt");
                    return View("Index");
                }
                return RedirectToAction("Success");
            } else {
                return View("Index");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
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
