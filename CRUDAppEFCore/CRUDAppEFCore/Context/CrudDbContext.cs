using CRUDAppEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.Context 
{
    public class CrudDbContext : DbContext
    {
        private readonly string _connectionString;
        public CrudDbContext(string connectionString)
        {
            // _connectionString = "Server=DESKTOP-HD3BUG1;Database=UniversityDbEF;User Id=sa;Password=subroto;";
            _connectionString = connectionString;
        }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.UseLazyLoadingProxies()
           .UseSqlServer(_connectionString);
        }
    }
}
