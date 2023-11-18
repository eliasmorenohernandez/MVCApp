using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index()
        //{
        //return "this is my default action....";
        //}

        // GET: HelloWorld/Details/5
        //public string Welcome(string name, int numTimes=1)
        //{
        //return "this is the welcome action method";
        //return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome( string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

    }
}
