using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;

namespace Project_G06.Controllers
{
    public class CompareController : Controller
    {
        private readonly WebAdminDbContext _context;

        public CompareController(WebAdminDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
