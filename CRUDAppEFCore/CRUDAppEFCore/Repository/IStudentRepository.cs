using Crud.DataAccessLayer;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Entities;

namespace CRUDAppEFCore.Repository
{
    public interface IStudentRepository: IRepository<Student, int, CrudDbContext>
    {
        //void Get();
        //void Add();
    }
}