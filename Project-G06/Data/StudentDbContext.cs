using Microsoft.EntityFrameworkCore;
using Project_G06.Models;
using ProjectG06.Migrations;

namespace Project_G06.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }

     /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>()
                .HasNoKey()
                .ToView("Add");
        }*/
        public DbSet<Register> Registers { get; set; }
    }
}
