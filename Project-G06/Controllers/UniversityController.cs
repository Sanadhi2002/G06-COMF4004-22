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
        public IActionResult Create()
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //ViewBag.userid = HttpContext.Session.GetString("Id");
            ViewBag.userid = UserId;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UniProfileModel obj)
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //ViewBag.userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (UserId == null /*|| UserId == 0*/)
            {
                return NotFound();
            }
            var UniProfileModelFromDb = _webApplication2DbContext.UniProfileModel.Find(UserId);
            if (UniProfileModelFromDb == null)
            {

                string uniqueFileName = UploadedFile(obj);
                obj.ProfilPic_URL = uniqueFileName;
                _webApplication2DbContext.Attach(obj);//attach the model to the Dbcontext and the change of the state of the model to entitystate.added.
                _webApplication2DbContext.Entry(obj).State = EntityState.Added;
                _webApplication2DbContext.SaveChanges();//then call the context.SaveChanges() method to add the record to the database
                return RedirectToAction("Details");//then call the index action to list the image record 




                //_webApplication2DbContext.Class.Add(obj);
                //_webApplication2DbContext.SaveChanges();
                //return RedirectToAction("Details");
            }
            return View(UniProfileModelFromDb);
        }
        private string UploadedFile(UniProfileModel obj) //function for save the uploaded binary stream of the uniprofilemodel in th images folder inside the wwwroot folder. afer that method will return the unique file name of the  image to the function
        {
            string uniqueFileName = null;
            if (obj.UploadedProfilePic != null)//check the usser has uploaded a file or not
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "profilepics");//if the user uploaded the file then we get the root path of the hosting directory this will return the path of the wwwroot folder. aftre that we add the image to the webrrot path since we want to store the file in the images folder
                uniqueFileName = Guid.NewGuid().ToString() + "_" + obj.UploadedProfilePic.FileName;//gigvinga a nuique file name to save the file so we use Guid.NewGuid method to get a new guid(globally unique identifier)
                string filepath = Path.Combine(uploadsFolder, uniqueFileName);//use the path.combine method to combine the file name with the uploaded folder name
                using (var fileStream = new FileStream(filepath, FileMode.Create))//save the uploaded file to the images folder using copyto method of the iform file interface
                {
                    obj.UploadedProfilePic.CopyTo(fileStream);
                }
            }
            return uniqueFileName;



        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
