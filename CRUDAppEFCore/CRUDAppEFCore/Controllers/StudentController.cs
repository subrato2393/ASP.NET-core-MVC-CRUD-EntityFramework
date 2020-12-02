using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAppEFCore.Controllers
{
    public class StudentController : Controller
    {
        CrudDbContext _db = new CrudDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            ViewBag.Departments = _db.Departments.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            ViewBag.Departments = _db.Departments.ToList();
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
            var students=_db.Students.ToList();
            return View(students);
        }
        public IActionResult Edit(int id)
        {
            var model=_db.Students.Find(id);
            ViewBag.Departments = _db.Departments.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _db.Entry(student).State = EntityState.Modified;
            _db.SaveChanges();
            ViewBag.Departments = _db.Departments.ToList();
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            var model = _db.Students.Find(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            _db.Entry(student).State = EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
