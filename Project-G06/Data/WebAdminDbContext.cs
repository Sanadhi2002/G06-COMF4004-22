using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class WebAdminDbContext : DbContext
    {
        public WebAdminDbContext(DbContextOptions <WebAdminDbContext>options) : base(options)
        {
        }
        public DbSet<WebAdmin> WebAdmins { get; set; }

      

        public DbSet<UniProfileModel> UniProfileModel { get; set; }
        public DbSet<DegreeModel> DegreeModel { get; set; }































































        public DbSet<Uni_FacultyModel> UniFacultyModel { get; set; }
        public DbSet<DegreeContentModel> DegreeContentModel { get; set; }
        public DbSet<AdmissionModel> AdmissionModel { get; set; }


    }

   
}
