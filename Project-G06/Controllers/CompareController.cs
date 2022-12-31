using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using Project_G06.Models;

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
            IEnumerable<DegreeModel> degreeList = _context.DegreeModel; 

            return View(degreeList);
        }
    }
}
