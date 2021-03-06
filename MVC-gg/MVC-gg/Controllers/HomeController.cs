using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_gg.Models;

namespace MVC_gg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult /*أخرب على أحمد*/ Index()
        { /*أخرب على أحمد*/
            return View(/*أخرب على أحمد*/);
            /*أخرب على أحمد*/
        }

        public IActionResult Privacy()
        {
            /*أخرب على ذيبان*/
            return View(/*أخرب على ذيبان*/);
        }

        public IActionResult About()
        {
            return Ok("المعروف لا يعرف");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
