using Microsoft.AspNetCore.Mvc;
using Project_G06.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_G06.Data;
using System.Diagnostics.Tracing;
using System.ComponentModel.DataAnnotations;
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



        [HttpPost]
        public IActionResult AddNew(Universities universities)
        {
            var university = new Universities()
            {
                Name =universities.Name,
                Email = universities.Email,
                Password = universities.Password,
                Date = universities.Date,

            };

            universityDbContext.RegisteredUniversities.Add(universities);
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
