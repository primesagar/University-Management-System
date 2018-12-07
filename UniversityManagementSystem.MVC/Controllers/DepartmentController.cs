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
    public class DepartmentController : Controller
    {
        // GET: Department
        DepartmentRepository _departmentRepository = new DepartmentRepository();
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            string messages = "";
            try
            {
                if (ModelState.IsValid)
                {
                    bool isSaved = _departmentRepository.AddDepartment(department);

                    if (isSaved)
                    {
                        messages = "Department Saved Successfully";
                        ViewBag.SMs = messages;
                    }
                }

                messages = Utility.GetModelStateError(ModelState);
                return View();
            }
            catch(Exception exception)
            {
                messages = exception.Message;
                ViewBag.SMg = messages;
                return View();
            }
           
        }



        //Get: Department/ViewDepartment
        public ActionResult ViewDepartment()
        {
            var deptLists = new Department();
             deptLists.DepartmentList = _departmentRepository.ShowDepartment().ToList();
            //List < Department > depart = _departmentRepository.ShowDepartment();
            return View(deptLists);
        }

        public string Department(Department department)
        {
            //return View();
            DepartmentRepository departmentRepository = new DepartmentRepository();
           
            bool isSaved = departmentRepository.AddDepartment(department);
            string messages = "";
            if (isSaved)
            {
                messages = "Department Saved Successfully";
            }

            return messages;
        }

        // GET: Department/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Department/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
