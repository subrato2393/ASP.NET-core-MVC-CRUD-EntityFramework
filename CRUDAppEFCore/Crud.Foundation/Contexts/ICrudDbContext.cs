using Crud.Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Foundation.Contexts
{
    public interface ICrudDbContext
    {
        DbSet<Department> Departments { get; set; }
        DbSet<Student> Students { get; set; }
    }
}