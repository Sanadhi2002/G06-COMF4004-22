using Microsoft.AspNetCore.Mvc;

namespace Project_G06.Controllers
{
    public class UniversitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
