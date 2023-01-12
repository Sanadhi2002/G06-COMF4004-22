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
        public async Task<IActionResult> Add(StudentEmail studentEmail,string email)
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


        //dulangi
        public IActionResult Index()
        {

            IEnumerable<StudentEmail> objStudentList = studentEmailDbContext.StudentEmails;
            return View(objStudentList);
        }




        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var studentFromDb = studentEmailDbContext.StudentEmails.Find(id);
            if (studentFromDb == null)
            {
                return NotFound();
            }

            return View(studentFromDb);


        }



        [HttpPost]
        public IActionResult Edit(StudentEmail student)
        {
            if (ModelState.IsValid)
            {
                studentEmailDbContext.StudentEmails.Update(student);
                studentEmailDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }






        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var studentFromDb = studentEmailDbContext.StudentEmails.Find(id);
            if (studentFromDb == null)
            {
                return NotFound();
            }

            return View(studentFromDb);

        }



        [HttpPost , ActionName("Delete")]
        public IActionResult DeletePOST (int? id)
        {

            var student = studentEmailDbContext.StudentEmails.Find(id);
            if (student == null)
            {
                return NotFound();  
            }

            studentEmailDbContext.StudentEmails.Remove(student);
            studentEmailDbContext.SaveChanges();
            return RedirectToAction("Index");
                
        }


    }

       
    }

