using Crud.DataAccessLayer;
using Crud.Foundation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Foundation.UnitOfWorks
{
    public interface IStudentUnitOfWork:IUnitOfWork
    {
        IDepartmentRepository DepartmentRepository { get; set; }
        IStudentRepository StudentRepository { get; set; }
    }
}
