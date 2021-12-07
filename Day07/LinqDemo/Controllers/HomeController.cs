using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LinqDemo.Models;

namespace LinqDemo.Controllers
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
            Game[] allGames = new Game[]
            {
                new Game {Title = "Pokemon Brilliant Diamond", Genre = "Adventure", Price = 60.00, Rating = "E", Platform = "Nintendo Switch", minNumPlayers = 1, maxNumPlayers = 1},
                new Game {Title = "Phasmophobia", Genre = "Horror", Price = 19.99, Rating = "M", Platform = "PC", minNumPlayers = 1, maxNumPlayers = 4},
                new Game {Title = "Death's Door", Genre = "Action", Price = 19.99, Rating = "T", Platform = "PC", minNumPlayers = 1, maxNumPlayers = 1},
                new Game {Title = "Life Is Strange", Genre = "Adventure", Price = 0.00, Rating = "M", Platform = "PC", minNumPlayers = 1, maxNumPlayers = 1},
                new Game {Title = "Halo Infinite", Genre = "FPS", Price = 59.99, Rating = "M", Platform = "XBOX", minNumPlayers = 1, maxNumPlayers = 24},
                new Game {Title = "The Legend of Zelda: Ocarina of Time", Genre = "Adventure", Price = 1000000.00, Rating = "E", Platform = "Nintendo 64", minNumPlayers = 1, maxNumPlayers = 1},
                new Game {Title = "Dreamlands", Genre = "Adventure", Price = 25.00, Rating = "E", Platform = "Role Playing", minNumPlayers = 1, maxNumPlayers = 4}
            };

            // This line: adventG => adventG.Genre == "Adventure"
            
            // As a foreach loop
            // foreach(Game adventG in allGames)
            // {
            //     if(adventG.Genre == "Adventure")
            //     {
            //         // Add to a list of adventure games
            //     }
            // }

            // As a function
            // function adventGames(game){
                // is the game passed in an adventure game?
                // if (game.Genre == "Adventure")
                // Do a thing, add to a list, etc...
            // }

            // As SQL
            // SELECT * WHERE games.genre = "Adventure" ORDER BY ASC 
            // Pass into List

            double priceMax = 20.00;
            string genre = "Adventure";
            ViewBag.AllGames = allGames;
            List<Game> AdventureGames = allGames.Where(adventG => adventG.Genre == genre).OrderByDescending(n => n.Title).ToList();
            // This is the top level version
            // IEnumerable<Game> AdventureGames = allGames.Where(adventG => adventG.Genre == "Adventure");
            ViewBag.AdventGames = AdventureGames;
            ViewBag.MaxPlayers = allGames.OrderBy(a => a.maxNumPlayers);
            ViewBag.Under20 = allGames.Where(g => g.Price < priceMax).ToList();
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
