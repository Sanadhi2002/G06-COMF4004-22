using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
