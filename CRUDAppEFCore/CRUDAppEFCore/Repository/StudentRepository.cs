using Crud.DataAccessLayer;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.Repository
{
    public class StudentRepository : Repository<Student, int, CrudDbContext>, IStudentRepository
    {
        public StudentRepository(CrudDbContext dbContext)
           : base(dbContext)
        {

        }      
    }
}
