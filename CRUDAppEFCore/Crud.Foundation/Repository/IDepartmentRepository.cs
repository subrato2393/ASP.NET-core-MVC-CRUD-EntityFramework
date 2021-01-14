using Crud.DataAccessLayer;
using Crud.Foundation.Contexts;
using Crud.Foundation.Entities;

namespace Crud.Foundation.Repository
{
    public interface IDepartmentRepository: IRepository<Department, int, CrudDbContext>
    {
        void Get();
    }
}