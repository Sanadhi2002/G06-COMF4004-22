using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;

namespace Project_G06.Controllers
{
    public class CorrectCompareController : Controller
    {
        private readonly WebApplication2DbContext _context;

        public CorrectCompareController(WebApplication2DbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchBy, string search)
        {
            if (searchBy == "Degre_Name")
            {
                return View(_context.DegreeModel.Where(x => x.Degre_Name.StartsWith(search) || search == null).ToList());
            }
             else if(searchBy == "Degree_Type")
            {
                return View(_context.DegreeModel.Where(x => x.Degree_Type.StartsWith(search) || search == null).ToList());
            }

            else
            {
                return View(_context.DegreeModel.Where(x => x.Affiliated_uni.StartsWith(search) || search == null).ToList());

            }
        }
    }
}
