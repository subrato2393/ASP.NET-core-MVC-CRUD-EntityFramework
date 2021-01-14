using Crud.DataAccessLayer;
using Crud.Foundation.Contexts;
using Crud.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Foundation.Repository
{
    public class DepartmentRepository : Repository<Department, int, CrudDbContext>, IDepartmentRepository
    {
        public DepartmentRepository(CrudDbContext dbContext)
           : base(dbContext)
        {

        }
        public void Get()
        {

        }
    }
}
