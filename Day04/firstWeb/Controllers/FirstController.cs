using Microsoft.AspNetCore.Mvc;

namespace firstWeb.Controllers
{
    public class FirstController : Controller
    {
        // This is where my routes and controls go
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("second/{param}")]
        public ViewResult Second(string param)
        {
            ViewBag.myParam = param;
            return View("Second");
        }

        [HttpGet("third")]
        public IActionResult Third()
        {
            return RedirectToAction("Index");
        }
    }
}