
using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
<<<<<<< HEAD
    public class WebAdminDbContext :DbContext
=======
    public class WebAdminDbContext : DbContext
>>>>>>> b7d6ba65a5b00732853bcca8f995fb93438546b5
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
