using Crud.DataAccessLayer;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.Repository
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
