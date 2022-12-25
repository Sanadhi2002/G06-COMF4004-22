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
        public async Task <IActionResult> AddFaculty(Faculties faculties)
        {
            var faculty = new Faculties()
            {
                Name = faculties.Name,
            };
            var user = await facultyDbContext.Faculties.FindAsync(faculty.Name);
            if(user == null)
            {
                 facultyDbContext.Faculties.Add(faculty);
                await facultyDbContext.SaveChangesAsync();
                return RedirectToAction("IndexFaculties");
            }

     
            return RedirectToAction("IndexFaculties");  

            
        }

        [HttpGet]
        public async Task <IActionResult > IndexFaculties()
        {
           var faculties = await  facultyDbContext.Faculties.ToListAsync();
            return View(faculties); 

                
        }

        [HttpGet] 
        public async Task< IActionResult> View(string Name)
        {
           var faculty = await   facultyDbContext.Faculties.FirstOrDefaultAsync(x => x.Name == Name);

            if (faculty != null)
            {

                var viewModel = new UpdateFacultyViewModel()
                {
                    Name = faculty.Name
                };

                return await  Task.Run (()=>View("View" ,viewModel));
            }



        }


        [HttpPost]
        public async Task<IActionResult> Delete (UpdateFacultyViewModel model)
        {
            var faculty  =  await  facultyDbContext.Faculties.FindAsync(model.Name);
            if(faculty != null)
            {
                facultyDbContext.Faculties.Remove(faculty);
                await facultyDbContext.SaveChangesAsync();
                return RedirectToAction("IndexFaculties");
            }
            return RedirectToAction("IndexFaculties");

        }
    }
}
