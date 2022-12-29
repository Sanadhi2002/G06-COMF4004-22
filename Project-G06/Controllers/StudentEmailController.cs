using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using Project_G06.Data;
using Project_G06.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
namespace Project_G06.Controllers
{
    public class StudentEmailController : Controller
    {
        private readonly StudentEmailDbContext studentEmailDbContext;
        public StudentEmailController(StudentEmailDbContext studentEmailDbContext)
        {
            this.studentEmailDbContext = studentEmailDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        
        [HttpPost]
        public async Task<IActionResult>  Add(StudentEmail studentEmail)
        {
            var student = new StudentEmail()
            {
                S_Email = studentEmail.S_Email,
                S_Id = studentEmail.S_Id,
                S_Name = studentEmail.S_Name,

            };
            
              await studentEmailDbContext.StudentEmails.AddAsync(studentEmail);
             await studentEmailDbContext.SaveChangesAsync();
                return RedirectToAction("Add");

            }
    



    }

       
    }

