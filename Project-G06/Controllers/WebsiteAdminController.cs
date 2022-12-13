using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_G06.Data;
using Project_G06.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
namespace Project_G06.Controllers
{
    public class WebsiteAdminController : Controller
    {
        private readonly WebsiteAdminRegDbContext websiteAdminRegDbContext;
        public WebsiteAdminController(WebsiteAdminRegDbContext websiteAdminRegDbContext)
        {
            this.websiteAdminRegDbContext = websiteAdminRegDbContext;
        }
        
        [HttpGet]
        public IActionResult WebsiteAdminRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WebsiteAdminRegistration(WebsiteAdmin websiteAdmin)
        {
            var websiteAdmins = new WebsiteAdmin()
            {
             W_Email= websiteAdmin.W_Email, 
            W_Id= websiteAdmin.W_Id,
             W_UserName= websiteAdmin.W_UserName,
             W_Password = websiteAdmin.W_Password
            };

            websiteAdminRegDbContext.WebsiteAdmins.Add(websiteAdmin);
            websiteAdminRegDbContext.SaveChanges();
            return RedirectToAction("WebsiteAdminRegistration");
        }
    }
}
