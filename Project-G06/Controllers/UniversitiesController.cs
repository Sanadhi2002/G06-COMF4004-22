using Microsoft.AspNetCore.Mvc;
using Project_G06.Models;

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


        public IActionResult AddNew(AddUniversityViewModel addUniversityRequest)
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
    }
}
