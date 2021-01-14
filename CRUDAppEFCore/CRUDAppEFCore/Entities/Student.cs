using Autofac;
using Crud.DataAccessLayer;
using CRUDAppEFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.Entities
{
    public class Student:IEntity<int>
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual Department Department { get; set; } 
        public int DepartmentId { get; set; }
      //  public virtual Department Department { get; set; }
       
        //private readonly CrudDbContext _db;
        ////public string DepartmentName { get; set; }
        ////public Student()
        ////{
        ////    var student = Startup.AutofacContainer.Resolve<Student>();
        ////}
        //public StudentModel()
        //{
        //    _db = Startup.AutofacContainer.Resolve<CrudDbContext>();
        //}
        //public void Add(StudentModel student)
        //{
        //    _db.Students.Add(student);
        //}
        //public void SaveChanges()
        //{
        //    _db.SaveChanges();
        //}
        //public IList<DepartmentModel> GetDepartments()
        //{
        //    return _db.Departments.ToList();
        //}
    }
}
