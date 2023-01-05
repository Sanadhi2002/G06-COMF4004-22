using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace Project_G06.Controllers
{
    // [Authorize(Roles = "Admin")]

    ////[Authorize(Roles = "Administrator")]
    public class AppRolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _rolemanager;
        public AppRolesController(RoleManager<IdentityRole> roleManager)
        {
            _rolemanager = roleManager;
        }
        //list all the roles created by users
        public IActionResult Index()
        {
            var roles = _rolemanager.Roles;
            return View(roles);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> create(IdentityRole model)
        {
            //avoid duplicate role
            if (!_rolemanager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                _rolemanager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }
            return RedirectToAction("Index");
        }
    }
}
