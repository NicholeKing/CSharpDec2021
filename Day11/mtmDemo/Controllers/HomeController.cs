using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mtmDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace mtmDemo.Controllers
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
            ViewBag.allMovies = _context.Movies.OrderBy(a => a.Title).ToList();
            return View();
        }

        [HttpPost("addMovie")]
        public IActionResult addMovie(Movie newMovie)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newMovie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                ViewBag.allMovies = _context.Movies.OrderBy(a => a.Title).ToList();
                return View("Index");
            }
        }

        [HttpGet("actors")]
        public IActionResult Actors()
        {
            ViewBag.AllActors = _context.Actors.OrderBy(s => s.FirstName).ToList();
            return View();
        }

        [HttpPost("addActor")]
        public IActionResult addActor(Actor newActor)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newActor);
                _context.SaveChanges();
                return RedirectToAction("Actors");
            } else {
                ViewBag.AllActors = _context.Actors.OrderBy(s => s.FirstName).ToList();
                return View("Actors");
            }
        }

        [HttpGet("movie/{movieId}")]
        public IActionResult OneMovie(int movieId)
        {
            Movie one = _context.Movies.Include(f => f.CastList).ThenInclude(g => g.Actor).FirstOrDefault(d => d.MovieId == movieId);
            ViewBag.allActors = _context.Actors.OrderBy(s => s.FirstName).ToList();
            return View(one);
        }

        [HttpPost("addToCast")]
        public IActionResult addToCast(Cast newRole)
        {
            _context.Add(newRole);
            _context.SaveChanges();
            return Redirect($"/movie/{newRole.MovieId}");
            // return RedirectToAction ("OneMovie", new {id = newRole.MovieId});
        }

        [HttpGet("actor/{actorId}")]
        public IActionResult OneActor(int actorId)
        {
            Actor one = _context.Actors.Include(f => f.ActedIn).ThenInclude(g => g.Movie).FirstOrDefault(d => d.ActorId == actorId);
            ViewBag.allMovies = _context.Movies.OrderBy(s => s.Title).ToList();
            return View(one);
        }

        [HttpPost("addToFilm")]
        public IActionResult addToFilm(Cast newRole)
        {
            _context.Add(newRole);
            _context.SaveChanges();
            return Redirect($"/actor/{newRole.ActorId}");
        }

        [HttpGet("movie/delete/{movieId}")]
        public IActionResult deleteMovie(int movieId)
        {
            // If we want to delete
            // Step one: find the object we intend to delete
            Movie mtd = _context.Movies.SingleOrDefault(s => s.MovieId == movieId);
            // Step two: delete it from the database
            _context.Movies.Remove(mtd);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("actor/delete/{actorId}")]
        public IActionResult deleteActor(int actorId)
        {
            // If we want to delete
            // Step one: find the object we intend to delete
            Actor atd = _context.Actors.SingleOrDefault(s => s.ActorId == actorId);
            // Step two: delete it from the database
            _context.Actors.Remove(atd);
            _context.SaveChanges();
            return RedirectToAction("Actors");
        }

        [HttpGet("delete/cast/{aid}/{mid}")]
        public IActionResult DeleteFromCast(int aid, int mid)
        {
            // We have to find the cast item where the actorid and movieid both show up
            Cast role = _context.Cast.SingleOrDefault(d => d.ActorId == aid && d.MovieId == mid);
            _context.Cast.Remove(role);
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
