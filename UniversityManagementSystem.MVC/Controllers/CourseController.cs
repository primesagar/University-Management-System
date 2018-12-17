using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models;
using UniversityManagementSystem.Models.Models;
using UniversityManagementSystem.MVC.Models;
using UniversityManagementSystem.Repositories.Repositories;

namespace UniversityManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        CourseRepository _courseRepository = new CourseRepository();
        // GET: Student
        [HttpGet]
        public ActionResult AddCourse()
        {
            var dList = new Department();
            var sList = new Semester();
            //dList.DepartmentList = _courseRepository.AllDepartment().ToList();
            //sList.SemesterList = _courseRepository.AllSemester().ToList();

            //ViewBag.dl = new SelectList(_courseRepository.AllDepartment().ToList(), "Name", "Id");
            //ViewBag.sl = new SelectList(_courseRepository.AllSemester().ToList(), "SemesterName", "Id");
            ViewBag.dl = _courseRepository.AllDepartment().ToList();
            ViewBag.sl = _courseRepository.AllSemester().ToList();
            ViewBag.Sm = TempData["Sm"];
            ViewBag.Em = TempData["Em"];
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            ViewBag.dl = _courseRepository.AllDepartment().ToList();
            ViewBag.sl = _courseRepository.AllSemester().ToList();
            string message = "";
            try
            { 
            if (ModelState.IsValid)
            {
                    //if(course.TeacherId == 0)
                    //{
                    //    course.TeacherId = null;
                    //}
                bool IsSaved = _courseRepository.AddCourse(course);
                if (IsSaved)
                {
                    message = "Course Saved Successfully";
                        //ViewBag.Sm = message;
                        TempData["Sm"] = message;
                }
                    //ViewBag.Um = "";
            }
                //ViewBag.Um = Utility.GetModelStateError(ModelState);
                TempData["Em"] = Utility.GetModelStateError(ModelState);
                //return View();
                return RedirectToAction("AddCourse");
            }
            catch(Exception exception)
            {
                message = exception.Message;
                TempData["Em"] = message;
                return RedirectToAction("AddCourse");
            }
        }

        [HttpGet]
        public ActionResult CourseAssignTeacher()
        {
            var model = new CourseAssignTeacherViewModel();
            model.DepartmentSelectListItems = _courseRepository.AllDepartment()
                .Select(c=> new SelectListItem() {Value = c.Id.ToString(), Text = c.Name}).ToList();
            model.TeacherSelectListItems = _courseRepository.AllTeacher()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            model.CourseSelectListItems = _courseRepository.AllCourse()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            //ViewBag.dpl = _courseRepository.AllDepartment().ToList();
            //ViewBag.tl = _courseRepository.AllTeacher().ToList();
            //ViewBag.cl = _courseRepository.AllCourse().ToList();

            ViewBag.Sm = TempData["Sm"];
            ViewBag.Em = TempData["Em"];
            return View(model);
        }

        [HttpPost]
        public ActionResult CourseAssignTeacher(Course course)
        {
            bool IsSaved = _courseRepository.UpdateCourseById(course);
            if (IsSaved)
            {
                TempData["Sm"] = "Course Assign Successfully";
            }
            else
            {
                TempData["Em"] = "Error Or Course Already Assigned to This Teacher";
            }
            return RedirectToAction("CourseAssignTeacher");
        }

        public JsonResult GetTeacherByDepartmentId(int departmentId)
        {
            //var dataList = _courseRepository.Get(c => c.DepartmentId == dId);
            var dataList = _courseRepository.AllTeacher();
            dataList = dataList.Where(c => c.DepartmentId == departmentId.ToString()).ToList();
            var jsonResult = dataList.Select(c => new { Id = c.Id, Name = c.Name });
            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCourseByDepartmentId(int departmentId)
        {
            var courseList = _courseRepository.AllCourse();
            courseList = courseList.Where(c => c.DepartmentId == departmentId).ToList();
            var jsonResult = courseList.Select(c => new { c.Id, c.Code });
            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetTeacherbyId(int teacherId)
        {
            var teacher = _courseRepository.AllTeacher().Where(c => c.Id == teacherId).FirstOrDefault();
            return Json(teacher.CreditLimit);
        }

        public JsonResult GetCourseById(int courseId)
        {
            var course = _courseRepository.AllCourse().Where(c => c.Id == courseId).FirstOrDefault();
            return Json(course);
        }

        public ActionResult ViewCourseStatic()
        {
            var model = new ViewCourseStaticsViewModel();
            model.DepartmentSelectListItems = _courseRepository.AllDepartment()
                .Select(c=> new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            model.CourseList = _courseRepository.AllCourseTS();
            //var CourseList = _courseRepository.AllCourse();
            return View(model);
        }

       
        public ActionResult GetCourseByDepartment(int departmentId)
        {

            //var course = _courseRepository.AllCourse().Where(c => c.SemesterId == departmentId).FirstOrDefault();
            //return Json(course);
            var model = new ViewCourseStaticsViewModel();
            model.CourseList = _courseRepository.AllCourseTS().Where(c => c.DepartmentId == departmentId).ToList();
            //var CAT = model.CourseList.Select(c => new { c.Code, c.Name, c.Semester.SemesterName }).ToList();
            return Json(model.CourseList);
        }
    }


}