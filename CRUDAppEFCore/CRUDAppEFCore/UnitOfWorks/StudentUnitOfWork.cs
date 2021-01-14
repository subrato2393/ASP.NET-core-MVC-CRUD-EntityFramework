using Crud.DataAccessLayer;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Repository;
using CRUDAppEFCore.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.UnitOfWorks
{
    public class StudentUnitOfWork : UnitOfWork, IStudentUnitOfWork
    {
        public IDepartmentRepository DepartmentRepository { get; set; }
        public IStudentRepository StudentRepository { get; set; }

        public StudentUnitOfWork(CrudDbContext context,
            IDepartmentRepository departmentReository,
            IStudentRepository studentRepository
            )
            : base(context)
        {
            DepartmentRepository = departmentReository;
            StudentRepository = studentRepository;
        }
    }
}
