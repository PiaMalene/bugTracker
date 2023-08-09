using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace bTracker.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
