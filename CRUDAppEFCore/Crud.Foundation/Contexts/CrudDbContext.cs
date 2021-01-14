using Crud.Foundation.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Foundation.Contexts
{
    public class CrudDbContext : DbContext, ICrudDbContext
    {
        private readonly string _connectionString;
        public CrudDbContext(string connectionString)
        {
            // _connectionString = "Server=DESKTOP-HD3BUG1;Database=UniversityDbEF;User Id=sa;Password=subroto;";
            _connectionString = connectionString;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.UseLazyLoadingProxies()
           .UseSqlServer(_connectionString);
        }
    }
}
