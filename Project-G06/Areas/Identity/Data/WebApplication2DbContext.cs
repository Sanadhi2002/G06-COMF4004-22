using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectG06.Migrations.WebAdminDb;

<<<<<<< HEAD:Project-G06/Areas/Identity/Data/WebApplication2DbContext.cs
using System.Reflection.Emit;
using Project_G06.Models;

namespace Project_G06.Areas.Identity.Data;

public class WebApplication2DbContext : IdentityDbContext<WebApplication2User>
=======
namespace Project_G06.Data
>>>>>>> 6940dc56baee2492cc030d4f72fa69340d3bcae2:Project-G06/Data/WebApplication2DbContext.cs
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

        public DbSet<Project_G06.Models.Class> Class { get; set; }
        public DbSet<degree> degree { get; set; }
    }
<<<<<<< HEAD:Project-G06/Areas/Identity/Data/WebApplication2DbContext.cs
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
=======
>>>>>>> 6940dc56baee2492cc030d4f72fa69340d3bcae2:Project-G06/Data/WebApplication2DbContext.cs
}
