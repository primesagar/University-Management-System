using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models;
using UniversityManagementSystem.Models.Models;
using UniversityManagementSystem.Repositories.Repositories;

namespace UniversityManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        TeacherRepository _teacherReporitory = new TeacherRepository();
        // GET: Student
        [HttpGet]
        public ActionResult AddTeacher()
        {
            ViewBag.dsl = _teacherReporitory.AllDesignation().ToList();
            ViewBag.dpl = _teacherReporitory.AllDepartment().ToList();
            ViewBag.Sm = TempData["Sm"];
            ViewBag.Em = TempData["Em"];
            return View();
        }

        [HttpPost]
        public ActionResult AddTeacher(Teacher teacher)
        {
            string message = "";
            try
            {
                if (ModelState.IsValid)
                {
                    bool IsSave = _teacherReporitory.SaveTeacher(teacher);
                    if (IsSave)
                    {
                        TempData["Sm"] = "Save Successfull";
                    }
                }
                TempData["Em"] = Utility.GetModelStateError(ModelState);
                return RedirectToAction("AddTeacher");
            }
            catch(Exception exception)
            {
                message = exception.Message;
                TempData["Em"] = message;
                return RedirectToAction("AddTeacher");
            }
            
        }
    }
}