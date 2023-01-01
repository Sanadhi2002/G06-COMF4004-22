using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_G06.Data;
using Project_G06.Models;
using System.Security.Claims;

namespace Project_G06.Controllers
{
    public class UniversityController : Controller
    {
        private readonly WebApplication2DbContext _webApplication2DbContext;
        private readonly UserManager<WebApplication2User> _userManager;
        private readonly SignInManager<WebApplication2User> _signInManager;
        private readonly IWebHostEnvironment webHostEnvironment; //get the access of service environment

        public UniversityController(WebApplication2DbContext webApplication2DbContext, UserManager<WebApplication2User> userManager,
           SignInManager<WebApplication2User> signInManager, IWebHostEnvironment webHost)
        {
            _webApplication2DbContext = webApplication2DbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            webHostEnvironment = webHost;
        }
        public async Task<IActionResult> Details()
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (UserId == null || _webApplication2DbContext.UniProfileModel == null)
            {
                return NotFound();
            }
            var UniProfileModel = _webApplication2DbContext.UniProfileModel.FirstOrDefault(m => m.UserId == UserId);
            if (UniProfileModel == null)
            {
                //return NotFound();
                return View();
            }
            return View(UniProfileModel);
        }
        public IActionResult Edit()
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (UserId == null /*|| UserId == 0*/)
            {
                return NotFound();
            }
            var UniProfileModelFromDb = _webApplication2DbContext.UniProfileModel.Find(UserId);
            if (UniProfileModelFromDb == null)
            {
                return RedirectToAction("Create");
            }
            return View(UniProfileModelFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UniProfileModel obj)
        {
            if (obj.UploadedProfilePic != null)
            {
                string uniqueFileName = UploadedFile(obj);
                obj.ProfilPic_URL = uniqueFileName;
            }
            _webApplication2DbContext.Attach(obj);
            _webApplication2DbContext.Entry(obj).State = EntityState.Modified;
            _webApplication2DbContext.SaveChanges();
            return RedirectToAction("Details");
            //if (ModelState.IsValid)
            //{
            //_webApplication2DbContext.Class.Update(obj);
            //    _webApplication2DbContext.SaveChanges();
            //    return RedirectToAction("Details");
            //}
            //return View(obj);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
