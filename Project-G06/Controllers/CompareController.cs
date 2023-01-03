using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;

namespace Project_G06.Controllers
{
    public class CompareController : Controller
    {

       

        private readonly StudentEmailDbContext studentEmailDbContext;
        public StudentEmailController(StudentEmailDbContext studentEmailDbContext)
        {
            this.studentEmailDbContext = studentEmailDbContext;
        }

        public IActionResult Index(string searchBy , string search)
        {
            if (searchBy == "S_Name")
            {
                return View(studentEmailDbContext.StudentEmails.Where(x => x.S_Name.StartsWith ( search) || search == null).ToList());
            }
            else
            {
                return View(studentEmailDbContext.StudentEmails.Where(x => x.S_Email.StartsWith(search) || search == null).ToList()) ;
            }
        }
    }
}
