using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class WebsiteAdminRegDbContext:DbContext
    {
        public WebsiteAdminRegDbContext(DbContextOptions<WebsiteAdminRegDbContext> options) : base(options)
        {

        }

        public DbSet<WebsiteAdmin> WebsiteAdmins { get; set; }
    }

}
