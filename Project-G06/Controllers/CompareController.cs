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

        public IActionResult Index(string searchBy , string search)
        {
            if (searchBy == "Degre_Name")
                return View(_context.DegreeModel.Where(x => x.Degre_Name == search || search == null).ToList());
            else
                return View(_context.DegreeModel.Where(x => x.Degree_Type == search || search == null).ToList());
        }
    }
}
