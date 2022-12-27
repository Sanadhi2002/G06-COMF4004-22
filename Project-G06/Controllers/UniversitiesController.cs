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
            //var Hashed = Hashpassword(universities.Password);


            var university = new Universities()
            {
                Name = universities.Name,
                Email = universities.Email,
                // Password = Hashed,
                Password = universities.Password,
                ConfirmPassword = universities.ConfirmPassword,
                Date = universities.Date,


            };
            //new part starts



            await universityDbContext.RegisteredUniversities.AddAsync(university);

            await universityDbContext.SaveChangesAsync();
            return RedirectToAction("Index");

        
        }




        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var registereduniversities = await universityDbContext.RegisteredUniversities.ToListAsync();
            return View(registereduniversities);
        }


  

     


       
        [HttpGet]
        public async Task<IActionResult>View(string name)
        {

            var singleuniversity = await  universityDbContext.RegisteredUniversities.FirstOrDefaultAsync(x => x.Name == name);
            if (singleuniversity != null)
            {
                var viewModel = new UpdateUniversity()
                {
                    Name = singleuniversity.Name,
                    Email = singleuniversity.Email,
                    // Password = Hashed,
                    Password = singleuniversity.Password,
                    ConfirmPassword = singleuniversity.ConfirmPassword,
                    Date = singleuniversity.Date,
                };
                return await View(viewModel);
            }
         
         
            return RedirectToAction("Index");
        }
















        [HttpPost]
        public async Task<IActionResult> View (UpdateUniversity model)
        {
            var university = await universityDbContext.RegisteredUniversities.FindAsync(model.Name);
            if (university != null)
            {
                university.Name = model.Name;
                university.Email = model.Email;
                university.Password = model.Password;
                university.ConfirmPassword = model.ConfirmPassword;
                university.Date = model.Date;

                await universityDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
                  

            }


            return RedirectToAction("Index");
        }

       
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateUniversity model)
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

        
    





    }
}
