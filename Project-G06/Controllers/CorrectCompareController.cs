using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using Project_G06.Models;

namespace Project_G06.Controllers
{
    public class CorrectCompareController : Controller
    {
        private readonly WebApplication2DbContext _context;

        public CorrectCompareController(WebApplication2DbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchBy, string search, int pg=1)
        {
            if (searchBy == "Degre_Name")
            {
                return View(_context.DegreeModel.Where(x => x.Degre_Name.StartsWith(search) || search == null).ToList());

               /* IEnumerable<DegreeModel> list1 = _context.DegreeModel.Where(x => x.Degre_Name.StartsWith(search) || search == null).ToList();
                const int pageSize = 6;
                if (pg < 1)
                {
                    pg = 1;
                }

                int recsCount = list1.Count();
                var pager = new PaginatedList(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;
                var data = list1.Skip(recSkip).Take(pager.PageSize).ToList();


                this.ViewBag.Pager = pager;

                return View(data);*/
            }
             else if(searchBy == "Degree_Type")
            {
                 return View(_context.DegreeModel.Where(x => x.Degree_Type.StartsWith(search) || search == null).ToList());
                /*IEnumerable<DegreeModel> list2 = _context.DegreeModel.Where(x => x.Degree_Type.StartsWith(search) || search == null).ToList();
                const int pageSize = 6;
                if (pg < 1)
                {
                    pg = 1;
                }

                int recsCount = list2.Count();
                var pager = new PaginatedList(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;
                var data = list2.Skip(recSkip).Take(pager.PageSize).ToList();


                this.ViewBag.Pager = pager;

                return View(data);*/
            }

            else
            {
                return View(_context.DegreeModel.Where(x => x.Affiliated_uni.StartsWith(search) || search == null).ToList());
               /*IEnumerable<DegreeModel> list2 = _context.DegreeModel.Where(x => x.Affiliated_uni.StartsWith(search) || search == null).ToList();
                const int pageSize = 6;
                if (pg < 1)
                {
                    pg = 1;
                }

                int recsCount = list2.Count();
                var pager = new PaginatedList(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;
                var data = list2.Skip(recSkip).Take(pager.PageSize).ToList();


                this.ViewBag.Pager = pager;

                return View(data);*/

            }
        }
    }
}
