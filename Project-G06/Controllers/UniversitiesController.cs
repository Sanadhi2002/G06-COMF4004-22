using Microsoft.AspNetCore.Mvc;
using Project_G06.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_G06.Data;
using Microsoft.EntityFrameworkCore;

namespace Project_G06.Controllers
{
    public class UniversitiesController : Controller
    {
        private readonly UniversityDbContext universityDbContext;

        public UniversitiesController(UniversityDbContext universityDbContext)
        {
            this.universityDbContext = universityDbContext;
        }

        [HttpGet]
        public IActionResult AddNew()
        {
            return View();
        }

       


        public IActionResult AddNew(Universities addUniversityRequest)
        {
            var universities = new Universities()
            {
                Name = addUniversityRequest.Name,
                Email = addUniversityRequest.Email,
                Password = addUniversityRequest.Password,
                Date = addUniversityRequest.Date,

            };

            universityDbContext.Add(universities);
            universityDbContext.SaveChanges();
            return RedirectToAction("AddNew");
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var registereduniversities = await universityDbContext.RegisteredUniversities.ToListAsync();
            return View(registereduniversities);
        }
    }
}
