using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using Project_G06.Models;
using Microsoft.EntityFrameworkCore;

namespace Project_G06.Controllers
{
    public class FacultiesController : Controller
    {
        private readonly FacultyDbContext facultyDbContext;

        public FacultiesController(FacultyDbContext facultyDbContext)
        {
            this.facultyDbContext = facultyDbContext;
        }


        [HttpGet]
        public IActionResult AddFaculty()
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> AddFaculty(AddFacultyViewModel addFacultyRequest)
        {
            var faculty = new Faculties()
            {

                F_Name = addFacultyRequest.F_Name,
            };

            await facultyDbContext.Faculties.AddAsync(faculty);
            await facultyDbContext.SaveChangesAsync();
            return RedirectToAction("AddFaculty");

        }

       
    }
}
        