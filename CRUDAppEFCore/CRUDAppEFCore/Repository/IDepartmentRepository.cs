using Crud.DataAccessLayer;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Entities;

namespace CRUDAppEFCore.Repository
{
    public interface IDepartmentRepository: IRepository<Department, int, CrudDbContext>
    {
        void Get();
    }
}