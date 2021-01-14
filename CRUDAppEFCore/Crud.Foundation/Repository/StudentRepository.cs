using Crud.DataAccessLayer;
using Crud.Foundation.Contexts;
using Crud.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Foundation.Repository
{
    public class StudentRepository : Repository<Student, int, CrudDbContext>, IStudentRepository
    {
        public StudentRepository(CrudDbContext dbContext)
           : base(dbContext)
        {

        }      
    }
}
