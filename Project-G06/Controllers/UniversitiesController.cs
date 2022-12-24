using Microsoft.AspNetCore.Mvc;
using Project_G06.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_G06.Data;
using System.Diagnostics.Tracing;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

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
        public async Task<IActionResult> AddNew(Universities universities)
        {
            var Hashed = Hashpassword(universities.Password);

          
            var university = new Universities()
            {
                Name = universities.Name,
                Email = universities.Email,
                Password = Hashed,
                //     Password = universities.Password,
                Date = universities.Date,
              //  Password = universities.Password,   
    
               

            };
            /*new part starts*/
            var user = await universityDbContext.RegisteredUniversities.FindAsync(universities.Name);
            if (user != null)
            {
                return BadRequest("Username already exists");
            }

            /*new part ends*/
            universityDbContext.RegisteredUniversities.Add(universities);
            universityDbContext.SaveChanges();
            return RedirectToAction("AddNew");
        }


       public  string Hashpassword(string pasword)
        {
            SHA256 hash= SHA256.Create();
            var passwordbytes = Encoding.Default.GetBytes(pasword); 
            var Hashedpassword =hash.ComputeHash(passwordbytes);
            return Convert.ToHexString(Hashedpassword);

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var registereduniversities = await universityDbContext.RegisteredUniversities.ToListAsync();
            return View(registereduniversities);
        }

      
        


        [HttpPost]
        public async Task<IActionResult> Delete(UpdateUniversityViewModel model)
        {
            var university = await universityDbContext.RegisteredUniversities.FindAsync(model.Name);
            if (university != null)
            {
                universityDbContext.RegisteredUniversities.Remove(university);
                await universityDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");

        }


  
        public IActionResult IndexFaculties()
        {
            return View();
        }



    }
}
