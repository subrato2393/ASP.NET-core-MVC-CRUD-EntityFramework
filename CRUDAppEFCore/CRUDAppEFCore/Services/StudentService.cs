using Autofac;
using CRUDAppEFCore.Entities;
using CRUDAppEFCore.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.Services
{
    public class StudentService:IStudentService
    {
        //private readonly IShoppingUnitOfWork _shopingUnitOfWork;
        //public StudentService(IShoppingUnitOfWork shopingUnitOfWork)
        //{
        //    _shopingUnitOfWork = shopingUnitOfWork;
        //}
        private readonly IStudentUnitOfWork _studentUnitOfWork;
        public StudentService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }
        public StudentService()
        {
            _studentUnitOfWork = Startup.AutofacContainer.Resolve<IStudentUnitOfWork>();
        }
        public void AddStudentEntity(Student student)
        {
            _studentUnitOfWork.StudentRepository.Add(student);
            _studentUnitOfWork.Save(); 
        }
        public IList<Department> GetAllDepartments()
        {
           return _studentUnitOfWork.DepartmentRepository.GetAll();
        }
        public IList<Student> GetAllStudents()
        {
           var studentList= _studentUnitOfWork.StudentRepository.GetAll();
           return studentList;
        }
    }
}
