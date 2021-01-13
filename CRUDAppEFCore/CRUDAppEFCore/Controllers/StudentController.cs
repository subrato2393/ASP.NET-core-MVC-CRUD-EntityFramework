using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAppEFCore.Controllers
{
    public class StudentController : Controller
    {
        //CrudDbContext _db = new CrudDbContext();
        StudentModel model = Startup.AutofacContainer.Resolve<StudentModel>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            //ViewBag.Departments = _db.Departments.ToList();
            ViewBag.Departments = model.GetDepartments();
            return View(); 
        }
        [HttpPost]
        public IActionResult Add(StudentModel student) 
        {
            student.Add(student);
            //_db.Students.Add(student);
            //_db.SaveChanges();
            student.SaveChanges();
            ViewBag.Departments = model.GetDepartments();
            return RedirectToAction("GetAll"); 
        }
        //public IActionResult GetAll()
        //{
        //    var students = _db.Students.ToList();
        //    return View(students);
        //}
        public IActionResult Edit(int id)
        {
            //var model=_db.Students.Find(id);
            ViewBag.Departments = model.GetDepartments();
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(StudentModel student)
        {
            //_db.Entry(student).State = EntityState.Modified;
            //_db.SaveChanges();
            ViewBag.Departments = model.GetDepartments();
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
           // var model = _db.Students.Find(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(StudentModel student)
        {
            //_db.Entry(student).State = EntityState.Deleted;
            //_db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
