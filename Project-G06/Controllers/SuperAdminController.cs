using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Project_G06.Areas.Identity;
using Project_G06.Data;
using Project_G06.Models;

namespace Project_G06.Controllers
{

    [Authorize(Roles = "Admin")]
    public class SuperAdminController : Controller
    {

        private readonly WebApplication2DbContext _webApplication2DbContext;
        private readonly UserManager<WebApplication2User> _userManager;
        private readonly SignInManager<WebApplication2User> _signInManager;
        private readonly IWebHostEnvironment webHostEnvironment; //get the access of service environment
        public SuperAdminController(WebApplication2DbContext webApplication2DbContext, UserManager<WebApplication2User> userManager,
            SignInManager<WebApplication2User> signInManager, IWebHostEnvironment webHost)
        {
            _webApplication2DbContext = webApplication2DbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            webHostEnvironment = webHost;
        }


        /*
        public IActionResult Index()
        {
            List<UniProfileModel> UniProfileModel;//create a list of type uniprofilemodel and set that list to _context.Uniprofiles.Tolist
            UniProfileModel = _webApplication2DbContext.UniProfileModel.ToList();
            return View(UniProfileModel);//then pass the list to the view to display on the screen 
        }


        */
        public IActionResult Degree(string Id)
        {
            IEnumerable<DegreeModel> DegreeList = _webApplication2DbContext.DegreeModel.Where(c => c.UserId == Id).ToList();
            return View(DegreeList);
        }

       
        public IActionResult Index1()
        {
            IEnumerable<UniProfileModel> objuniversitylist = _webApplication2DbContext.UniProfileModel;
            return View(objuniversitylist);
        }

        public IActionResult Delete(string? id)
        {
            if(id == null)
            {
                return NotFound();         
            }

            var universityFromDb = _webApplication2DbContext.UniProfileModel.Find(id);
            if (universityFromDb == null)
            {
                return NotFound();
            }

            return View(universityFromDb);
        }



        [HttpPost , ActionName("Delete")]
        public IActionResult DeletePOST (string? id)
        {
            var universityFromDb = _webApplication2DbContext.UniProfileModel.Find(id);
            if (universityFromDb == null) 
            {
             
                return NotFound();
            }

            _webApplication2DbContext.UniProfileModel.Remove(universityFromDb);
            _webApplication2DbContext.SaveChanges();
            TempData["Success"] = "Deleted successfully";
            return RedirectToAction("Index1");
        
        }

     
      

 
      

        

    }
}
