using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class StudentEmailDbContext : DbContext
    {

        public StudentEmailDbContext(DbContextOptions<StudentEmailDbContext> options) : base(options)
        {

        }
        public DbSet<StudentEmail> StudentEmails { get; set; }
        //public DbSet<Category>categories { get; set; }
       

    }
}
