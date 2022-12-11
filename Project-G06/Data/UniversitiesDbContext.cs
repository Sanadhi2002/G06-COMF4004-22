using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class UniversitiesDbContext : DbContext
    {
        public UniversitiesDbContext(DbContextOptions<UniversitiesDbContext> options) : base(options)
        {

        }

        public DbSet<Universities> Name { get; set; }
    }
}

