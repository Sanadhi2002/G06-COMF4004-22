using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class WebAdminDbContext : IdentityDbContext
    {
        public WebAdminDbContext(DbContextOptions <WebAdminDbContext>options) : base(options)
        {
        }
        public DbSet<WebAdmin> WebAdmins { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

    }

   
}
