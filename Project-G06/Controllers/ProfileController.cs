using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using Project_G06.Models;
using System.Diagnostics.CodeAnalysis;

namespace Project_G06.Controllers
{
    public class ProfileController : Controller
    {
        private readonly StudentEmailDbContext studentEmailDbContext;

        public ProfileController(StudentEmailDbContext studentEmailDbContext)
        {
            this.studentEmailDbContext = studentEmailDbContext;
        }


        public IActionResult Index(string SearchBy , string search)
        {
            if (SearchBy == "Name")
            {
                IEnumerable<StudentEmail> objCategoryList = studentEmailDbContext.StudentEmails.Where(x => x.S_Name == search || search == null);
                return View(objCategoryList);
            }
            else
            {
                IEnumerable<StudentEmail> objCategoryList = studentEmailDbContext.StudentEmails.Where(x => x.S_Name.StartsWith(search) ||search == null );
                return View(objCategoryList);
            }
        }
    }
}
