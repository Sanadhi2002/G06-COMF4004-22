using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class UniProfileDbContext:DbContext
    {
        public UniProfileDbContext(DbContextOptions<UniProfileDbContext> options) : base(options)
        {

        }
        public DbSet<UniProfileModel> UniProfileModels { get; set; } //create UniProfileModel  table name with UniProfileModels
    }
}
