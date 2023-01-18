using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using PagedList;
using Project_G06.Models;


namespace Project_G06.Controllers
{
    public class CompareController : Controller
    {

        private readonly StudentEmailDbContext  _context;

        public CompareController(StudentEmailDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchBy, string search , int pg =1)
        {
            if (searchBy == "S_Name")
            {
                // return View(_context.StudentEmails.Where(x => x.S_Name .StartsWith( search) || search == null).ToList());

                IEnumerable<StudentEmail> list1 = _context.StudentEmails.Where(x => x.S_Name.StartsWith(search) || search == null).ToList();
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

                return View(data);
            }
            else
            {
               // return View(_context.StudentEmails.Where(x => x.S_Email.StartsWith(search) || search == null).ToList());
                IEnumerable<StudentEmail> list2 = _context.StudentEmails.Where(x => x.S_Email.StartsWith(search) || search == null).ToList();
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

                return View(data);
            }
        }
    }
}
