using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using efDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace efDemo.Controllers
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
            ViewBag.AllMusic = _context.Music.OrderBy(a => a.Title).ToList();
            return View();
        }

        [HttpPost("addMusic")]
        public IActionResult addMusic(Music newSong)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newSong);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("Index");
            }
        }
        [HttpGet("delete/{musicId}")]
        public IActionResult DeleteSong(int musicId)
        {
            // Find the song
            Music songToDelete = _context.Music.SingleOrDefault(s => s.MusicId == musicId);
            // Remove from the database
            _context.Music.Remove(songToDelete);
            // Save the changes
            _context.SaveChanges();
            // Head back to Index
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{musicId}")]
        public IActionResult Edit(int musicId)
        {
            Music oneSong = _context.Music.FirstOrDefault(a => a.MusicId == musicId);
            return View(oneSong);
        }

        [HttpPost("updateMusic/{musicId}")]
        public IActionResult Update(int musicId, Music songToUpdate)
        {
            if(ModelState.IsValid)
            {
                // We need to find the old version
                Music oldSong = _context.Music.FirstOrDefault(a => a.MusicId == musicId);
                oldSong.Title = songToUpdate.Title;
                oldSong.Artist = songToUpdate.Artist;
                oldSong.Genre = songToUpdate.Genre;
                oldSong.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("Edit", songToUpdate);
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
