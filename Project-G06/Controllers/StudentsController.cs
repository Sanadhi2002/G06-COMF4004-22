using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_G06.Data;
using Project_G06.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace Project_G06.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentDbContext studentDbContext;

        public StudentsController(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Add(Register register)
        {
           
            var registers= new Register();
            {
             var  Name= register.Name;
             var Email=register.Email;

            }
          studentDbContext.Registers.Add(register);
          studentDbContext.SaveChanges();
            return RedirectToAction("Add");
        }
    }

}
