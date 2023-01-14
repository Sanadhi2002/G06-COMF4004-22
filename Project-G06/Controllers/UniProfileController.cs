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
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _webApplication2DbContext.UniProfileModel == null)
            {
                return NotFound();
            }

            var uniModel = _webApplication2DbContext.UniProfileModel.FirstOrDefault(m => m.UserId == id);
            if (uniModel == null)
            {
                return NotFound();
            }

            return View(uniModel);

        }
        public IActionResult Degree(string Id)
        {
            IEnumerable<DegreeModel> DegreeList = _webApplication2DbContext.DegreeModel.Where(c => c.UserId == Id).ToList()/*.FirstOrDefault()*/;
            return View(DegreeList);


        }
        public async Task<IActionResult> DegreeDetails(int? id)
        {
            if (id == null || _webApplication2DbContext.DegreeModel == null)
            {
                return NotFound();
            }

            var DegreeModel = _webApplication2DbContext.DegreeModel.FirstOrDefault(m => m.Degree_ID == id);
            if (DegreeModel == null)
            {
                return NotFound();
            }

            return View(DegreeModel);

        }
    }
}
