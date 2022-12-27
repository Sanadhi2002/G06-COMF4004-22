using Microsoft.EntityFrameworkCore;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class CategoryDbContext : DbContext
    {


        public CategoryDbContext(DbContextOptions<CategoryDbContext> options) : base(options)
        {

        }
        public DbSet<Category> categories{ get; set; }

    } 


}
