using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Universities> RegisteredUniversities { get; set; }

        internal object Find(string name)
        {
            throw new NotImplementedException();
        }
    }

    
}
