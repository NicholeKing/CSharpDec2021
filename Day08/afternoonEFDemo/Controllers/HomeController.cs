using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using afternoonEFDemo.Models;
// Don't forget to bring in entity framework
using Microsoft.EntityFrameworkCore;

namespace afternoonEFDemo.Controllers
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
            // Grab all animals
            //                      DB     Table  .Actions
            ViewBag.AllAnimals = _context.Animals.ToList();
            return View();
        }

        [HttpPost("addAnimal")]
        public IActionResult addAnimal(Animal newAnimal)
        {
            // If we pass validations
            if(ModelState.IsValid)
            {
                // Add to the database
                // Note: we do not need to specify the table because the model being passed in should match a table
                _context.Add(newAnimal);
                // Always save your changes
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                // Otherwise, show the Index page so we can see errors
                return View("Index");
            }
        }

        [HttpGet("animal/{anId}")]
        public IActionResult oneAnimal(int anId)
        {
            Animal one = _context.Animals.FirstOrDefault(a => a.AnimalId == anId);
            return View(one);
        }

        [HttpGet("delete/{anId}")]
        public IActionResult deleteOne(int anId)
        {
            // Steps to delete
            // Step one: get the thing you're trying to delete
            Animal oneAnimal = _context.Animals.SingleOrDefault(a => a.AnimalId == anId);
            // Step two: delete the animal from the database
            _context.Animals.Remove(oneAnimal);
            // Step Three: save your changes
            _context.SaveChanges();
            // We want to redirect to a page that still exists
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{anId}")]
        public IActionResult Edit(int anId)
        {
            // Step one: find the animal we're trying to edit
            Animal oneAnimal = _context.Animals.FirstOrDefault(a => a.AnimalId == anId);
            // Step two: send the animal over to the view
            return View(oneAnimal);
        }

        // This is the post request for our update
        [HttpPost("updateAnimal/{anId}")]
        public IActionResult Update(int anId, Animal edited)
        {
            // Steps to update:
            // Step one: find the original thing I'm updating
            Animal original = _context.Animals.FirstOrDefault(a => a.AnimalId == anId);
            // Step Two: overwrite the original data with the new data
            // and don't forget to update the updatedAt section
            original.Species = edited.Species;
            original.numLegs = edited.numLegs;
            original.isMammal = edited.isMammal;
            original.UpdatedAt = DateTime.Now;
            // Step three: save your changes
            _context.SaveChanges();
            return RedirectToAction("Index");
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
