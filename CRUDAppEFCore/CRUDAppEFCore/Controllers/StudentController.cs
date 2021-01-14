using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using CRUDAppEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAppEFCore.Controllers
{
    public class StudentController : Controller
    {
        public StudentController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            var model = Startup.AutofacContainer.Resolve<DepartmentModel>();
            ViewBag.Departments = model.GetDepartments();
            return View();
        }
        [HttpPost]
        public IActionResult Add(StudentModel model)
        {
            model.AddStudent(); 
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
            var model = Startup.AutofacContainer.Resolve<StudentModel>();
            var students = model.GetAllStudent();
            return View(students);
        }
        public IActionResult Edit(int id)
        {
            //var model=_db.Students.Find(id);
            //ViewBag.Departments = model.GetDepartments();
            return View();
        }
        [HttpPost]
        public IActionResult Edit()
        {
            //_db.Entry(student).State = EntityState.Modified;
            //_db.SaveChanges();
            //ViewBag.Departments = model.GetDepartments();
            return RedirectToAction("GetAll");
        }
        //public IActionResult Delete(int id)
        //{
        //   // var model = _db.Students.Find(id);
        //    return View(model);
        //}
        // [HttpPost]
        //public IActionResult Delete(StudentModel student)
        //{
        //    //_db.Entry(student).State = EntityState.Deleted;
        //    //_db.SaveChanges();
        //    return RedirectToAction("GetAll");
        //}
        //}
    }
}
