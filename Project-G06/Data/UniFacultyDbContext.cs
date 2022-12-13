using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class UniFacultyDbContext:DbContext
    {
        public UniFacultyDbContext(DbContextOptions<UniFacultyDbContext> options) : base(options)
        {

        }
        public DbSet<Uni_FacultyModel> UnifacultyModels { get; set; } //create UniProfileModel  table name with UniProfileModels
    }
}
