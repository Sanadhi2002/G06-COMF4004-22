using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectG06.Migrations.WebAdminDb;


using Project_G06.Models;
using degree = Project_G06.Models.degree;

namespace Project_G06.Data
{
    public class WebApplication2DbContext : IdentityDbContext<WebApplication2User>
    {
        public WebApplication2DbContext(DbContextOptions<WebApplication2DbContext> options)
        : base(options)

        {
        }


        //public DbSet<Class> Class { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //builder.Entity<WebApplication2User>()
            //     .HasOne<Class>(e => e.Id)
            //.WithOne(em => em.WebApplication2User)
            //.HasForeignKey<Class>(em => em.UserId);
            //modelBuilder.Entity<WebApplication2User>()
            //    .HasOptional(m => m.Class)
            //    .WithRequired(m => m.WebApplication2User)
            //    .Map(p => p.MapKey("UserId"));
        }
        //public DbSet<Class> Class { get; set; }

        public DbSet<Class> Class { get; set; }
        public DbSet<degree> degree { get; set; }
    }
}