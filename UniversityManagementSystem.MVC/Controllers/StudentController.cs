using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Repositories.Repositories;
using UniversityManagementSystem.Models.Models;
using UniversityManagementSystem.Repositories;
using UniversityManagementSystem.MVC.Models;

namespace UniversityManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository _studentRepository = new StudentRepository();
        // GET: Student
        public ActionResult RegisterStudent()
        {
            var model = new StudentRegisterViewModel();
            model.DepartmentSelectListItems = _studentRepository.AllDepatrmint()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
                 
            return View(model);
        }
    }
}