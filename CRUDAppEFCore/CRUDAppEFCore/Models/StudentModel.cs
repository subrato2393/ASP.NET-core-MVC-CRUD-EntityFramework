using Autofac;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.Models
{
    public class StudentModel
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; } 
        public virtual DepartmentModel Department { get; set; }
        private readonly CrudDbContext _db;
        //public string DepartmentName { get; set; }
        //public Student()
        //{
        //    var student = Startup.AutofacContainer.Resolve<Student>();
        //}
        public StudentModel()
        {
            _db = Startup.AutofacContainer.Resolve<CrudDbContext>();
        }
        public void Add(StudentModel student)
        {
            _db.Students.Add(student);
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
        public IList<DepartmentModel> GetDepartments()
        {
            return _db.Departments.ToList();
        }
    }
}
