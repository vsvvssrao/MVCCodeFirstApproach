using MvcSpaDemo.DataAccess;
using MvcSpaDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSpaDemo.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult _Index()
        {
            var students = StudentData.GetStudents();
            return PartialView(students);
        }

        public ActionResult Add()
        {
            var student = new Student();
            ViewBag.Status = "Add";
            return PartialView(student);
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentData.AddStudent(student);
                return Json(true, JsonRequestBehavior.AllowGet);

            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int studentID)
        {
            var student = StudentData.GetStudentById(studentID);
            ViewBag.Status = "Edit";
            return PartialView("Add", student);
        }

        [HttpPost]
        public ActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentData.UpdateStudent(student);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int studentID)
        {
            StudentData.DeleteStudent(studentID);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}