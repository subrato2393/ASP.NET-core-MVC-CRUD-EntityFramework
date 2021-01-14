using Crud.DataAccessLayer;
using Crud.Foundation.Contexts;
using Crud.Foundation.Entities;

namespace Crud.Foundation.Repository
{
    public interface IStudentRepository: IRepository<Student, int, CrudDbContext>
    {
        //void Get();
        //void Add();
    }
}