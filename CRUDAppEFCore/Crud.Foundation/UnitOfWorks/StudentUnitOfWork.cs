using Crud.DataAccessLayer;
using Crud.Foundation.Contexts;
using Crud.Foundation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Foundation.UnitOfWorks
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
