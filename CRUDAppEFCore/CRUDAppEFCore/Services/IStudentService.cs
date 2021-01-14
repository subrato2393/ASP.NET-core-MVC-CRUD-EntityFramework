using CRUDAppEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore.Services
{
    public interface IStudentService
    {
        void AddStudentEntity(Student student);
        IList<Department> GetAllDepartments();
        IList<Student> GetAllStudents();
    }
}
