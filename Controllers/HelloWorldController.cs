using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvc_movie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWord/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int  numTimes = 1)
        {
            ViewData["Message"] = "Olá " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}