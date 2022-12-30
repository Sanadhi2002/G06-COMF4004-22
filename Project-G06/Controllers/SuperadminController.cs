using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_G06.Data;
using Project_G06.Models;

namespace Project_G06.Controllers
{
    public class SuperadminController : Controller
    {


        private readonly WebAdminDbContext _context;

        public SuperadminController(WebAdminDbContext webAdminDbContext)
        {
            _context = webAdminDbContext;

        }


        public  async Task<IActionResult> Index()
        {
            
              return View (await _context.WebAdmins.ToListAsync());
 
        }



    }
}
