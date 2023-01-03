
﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Emit;
﻿using Microsoft.AspNetCore.Builder;
using Project_G06.Models;



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


        public DbSet<Project_G06.Models.Class> Class { get; set; }
        public DbSet<Project_G06.Models.degree> degree { get; set; }

        public DbSet<UniProfileModel> UniProfileModel { get; set; }
        public DbSet<DegreeModel> DegreeModel { get; set; }
    }
}

       
