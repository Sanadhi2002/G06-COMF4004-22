﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Project_G06.Models;

namespace Project_G06.Data
{
    public class StudentEmailDbContext : DbContext
    {
        public StudentEmailDbContext()
        {
        }

        public StudentEmailDbContext(DbContextOptions<StudentEmailDbContext> options) : base(options)
        {
                
        }
        public DbSet<StudentEmail> StudentEmails { get; set; }

        internal object Find(object s_Email)
        {
            throw new NotImplementedException();
        }
        //public DbSet<Category>categories { get; set; }


    }
}
