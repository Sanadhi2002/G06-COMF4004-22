using Microsoft.AspNetCore.Mvc;
using Project_G06.Models;
using System.Diagnostics;

namespace Project_G06.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult aboutUs()
        {
            return View();
        }
        public IActionResult Compare()
        {
            return View();
        }
        public IActionResult UnivProfile()
        {
            return View();
        }
        public IActionResult LOGINSUPERADMIN()
        {
            return View();
        }

        public IActionResult unireg()
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