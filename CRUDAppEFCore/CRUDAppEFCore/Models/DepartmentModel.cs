using Autofac;
using CRUDAppEFCore.Entities;
using CRUDAppEFCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual List<StudentModel> Students { get; set; }

        private readonly IStudentService _studentService;
        public DepartmentModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public DepartmentModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }
        public IList<Department> GetDepartments()
        {
            return _studentService.GetAllDepartments();
        } 
    }
} 
