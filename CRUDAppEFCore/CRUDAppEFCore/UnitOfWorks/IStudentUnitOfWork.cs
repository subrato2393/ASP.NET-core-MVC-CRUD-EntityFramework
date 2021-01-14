using Crud.DataAccessLayer;
using CRUDAppEFCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.UnitOfWorks
{
    public interface IStudentUnitOfWork:IUnitOfWork
    {
        IDepartmentRepository DepartmentRepository { get; set; }
        IStudentRepository StudentRepository { get; set; }
    }
}
