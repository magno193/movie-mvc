using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvc_movie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWord/
        public string Index()
        {
            return "Está é a minha ação padrão.";
        }

        // GET: /HelloWorld/Welcome
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Ola {name}, ID: {ID}");
        }
    }
}