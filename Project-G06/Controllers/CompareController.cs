using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using PagedList;


namespace Project_G06.Controllers
{
    public class CompareController : Controller
    {

        private readonly StudentEmailDbContext  _context;

        public CompareController(StudentEmailDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchBy, string search , int? page)
        {
            if (searchBy == "S_Name")
            {
                return View(_context.StudentEmails.Where(x => x.S_Name .StartsWith( search) || search == null).ToList());
            }
            else
            {
                return View(_context.StudentEmails.Where(x => x.S_Email.StartsWith(search) || search == null).ToList());
            }
        }
    }
}
