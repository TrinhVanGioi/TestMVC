using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace TestMVC.Controllers
{
    public class StudentController : Controller
    {
        StudentEntities dbcontext = new StudentEntities();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
          return View();
        }
        [HttpPost]
        public ActionResult Create(StudentViewModel student)
        {
            Student s = new Student();
            s.StudentId = 1;
            s.StudentCode = student.StudentCode;
            s.FirstName = student.FirstName;
            s.LastName = student.LastName;
            s.Gender = student.Gender;
            s.DateOfBirth = student.DateOfBirth;
            dbcontext.Entry(s).State = EntityState.Added;
            dbcontext.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(StudentViewModel student)
        {


            var s = (from m in dbcontext.Students
                     where m.StudentId == student.StudentId
                     select m).FirstOrDefault(); ;
            s.StudentCode = student.StudentCode;
            s.FirstName = student.FirstName;
            s.LastName = student.LastName;
            s.Gender = student.Gender;
            s.DateOfBirth = student.DateOfBirth;
            dbcontext.Entry(s).State = EntityState.Modified;
            dbcontext.SaveChanges();
            return View();
        }
            
    }
}
