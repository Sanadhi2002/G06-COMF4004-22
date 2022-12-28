using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using Project_G06.Models;
using System.Diagnostics.CodeAnalysis;

namespace Project_G06.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UniProfileDbContext uniProfileDbContext1;
       
        public ProfileController(UniProfileDbContext uniProfileDbContext)
        { 
            uniProfileDbContext1 = uniProfileDbContext; 

        }
        public IActionResult Index()
        {
            IEnumerable<UniProfileModel> ProfileAttributesList = uniProfileDbContext1.UniProfileModels;

            return View(ProfileAttributesList);
        }
    }
}
