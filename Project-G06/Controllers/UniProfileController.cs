using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using Project_G06.Models;

namespace Project_G06.Controllers
{
    public class UniProfileController : Controller
    {
        private readonly WebApplication2DbContext _webApplication2DbContext;
        public UniProfileController(WebApplication2DbContext webApplication2DbContext)
        {
            _webApplication2DbContext= webApplication2DbContext;
        }
        public IActionResult UniProfile()
        {
            IEnumerable<UniProfileModel> objUniProfileModel = _webApplication2DbContext.UniProfileModel.ToList();
            return View(objUniProfileModel);
        }
    }
}
