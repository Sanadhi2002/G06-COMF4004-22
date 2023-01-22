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
            var checkforuser = studentEmailDbContext.StudentEmails.Where(x => x.S_Email == email).SingleOrDefault();
            if (checkforuser != null)
            {

                RedirectToAction("Add");
                TempData["Error"] = "Already registered";

            }
            
            
                await studentEmailDbContext.StudentEmails.AddAsync(studentEmail);
                await studentEmailDbContext.SaveChangesAsync();
                TempData["Success"] = "registered successfully";

                return RedirectToAction("Index");
            

           


        }
        
        
      



        //dulangi
        public   IActionResult  Index(int pg =1)
        {
            //@model IEnumerable<StudentEmail> put this in the index view//
            // IEnumerable<StudentEmail> objStudentList = studentEmailDbContext.StudentEmails;
            // return View(await PaginatedList<StudentEmail>.CreateAsync(studentEmailDbContext.StudentEmails, pageNumber , 5 ));
            // return View(objStudentList);
            IEnumerable<StudentEmail> objStudentList = studentEmailDbContext.StudentEmails;
            const int pageSize = 5;
            if (pg<1)
            {
                pg = 1;
            }
            int recsCount = objStudentList.Count();
            var pager = new PaginatedList(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = objStudentList.Skip(recSkip).Take(pager.PageSize).ToList();


            this.ViewBag.Pager = pager;

            return View(data);
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
                TempData["Success"] = "record edited successfully";
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
            TempData["Success"] = "User deleted successfully";
            return RedirectToAction("Index");
                
        }


    }

       
    }

