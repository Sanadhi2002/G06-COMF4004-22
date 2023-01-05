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

    ////[Authorize(Roles = "Administrator")]
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
        public IActionResult Index()
        {
            List<UniProfileModel> UniProfileModel;//create a list of type uniprofilemodel and set that list to _context.Uniprofiles.Tolist
            UniProfileModel = _webApplication2DbContext.UniProfileModel.ToList();
            return View(UniProfileModel);//then pass the list to the view to display on the screen 
        }
        public IActionResult Degree(string Id)
        {
            IEnumerable<DegreeModel> DegreeList = _webApplication2DbContext.DegreeModel.Where(c => c.UserId == Id).ToList();
            return View(DegreeList);
        }

       
        //get 
        public IActionResult Edit(string Userid)
        {
            if (Userid == null )
            {
                return NotFound();
            }
            var item = _webApplication2DbContext.UniProfileModel.Find(Userid);
            if(item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(  UniProfileModel item)
        {
            if (ModelState.IsValid)
            {
                _webApplication2DbContext.UniProfileModel.Update(item);
                _webApplication2DbContext.SaveChanges();
                return RedirectToAction("Index");

                
            }

            return View(item);
        }


        public IActionResult Delete(string Userid)
        {
            if (Userid == null)
            {
                return NotFound();
            }

            var item = _webApplication2DbContext.UniProfileModel.Find(Userid);

            if (item == null)
            {
                return NotFound();
            }
            return View(item);

        }

        [HttpPost , ActionName("Delete")]

        public IActionResult DeletePOST (string Userid)
        {
            var item = _webApplication2DbContext.UniProfileModel.Find(Userid);

            if (item == null)
            {
                return NotFound();
            }

            _webApplication2DbContext.UniProfileModel.Remove(item);
            _webApplication2DbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        

    }
}
