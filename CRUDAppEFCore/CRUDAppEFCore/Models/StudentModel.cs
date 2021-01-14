using Autofac;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Entities;
using CRUDAppEFCore.Services;
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
        public string DepartmentName { get; set;}
        public int DepartmentId { get; set; }
        public virtual DepartmentModel Department { get; set; }

        private readonly IStudentService _studentService;
        public StudentModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public StudentModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        } 
        public void AddStudent()
        {
            _studentService.AddStudentEntity(new Student()
            {
                Name = Name,
                Email = Email,
                Address = Address,
                DepartmentId = DepartmentId
            });
        }
        public object GetAllStudent()
        {
            var studentList = _studentService.GetAllStudents();
            IEnumerable<StudentModel> studentModel = ConvertStudentEntityToModel(studentList);
            return studentModel.ToList();
        }

        private static IEnumerable<StudentModel> ConvertStudentEntityToModel(IList<Student> studentList)
        {
            return studentList.Select(x => new StudentModel()
            {
                Name = x.Name,
                Address = x.Address,
                Email = x.Email,
                DepartmentId = x.DepartmentId,
                Id = x.Id,
                DepartmentName = x.Department.Name
            });
        }
    }
}