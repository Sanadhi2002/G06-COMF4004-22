using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class FacultyDbContext : DbContext
    {
        public FacultyDbContext(DbContextOptions <FacultyDbContext>options) : base(options)
        {
        }

        public DbSet<Faculties> Faculties { get; set; }
    }
}
