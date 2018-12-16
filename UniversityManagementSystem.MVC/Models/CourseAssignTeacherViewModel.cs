using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.Models;

namespace UniversityManagementSystem.MVC.Models
{
    public class CourseAssignTeacherViewModel
    {
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 5)]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public int Credit { get; set; }
        public string Description { get; set; }
        [Required]
        public string SemesterId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public int TeacherId { get; set; }
        [DefaultValue("false")]
        public bool DeletualStatus { get; set; }
        public List<SelectListItem> DepartmentSelectListItems { get; set; }
        public List<SelectListItem> TeacherSelectListItems { get; set; }
        public List<SelectListItem> CourseSelectListItems { get; set; }
        //public Department Department { get; set; }
        //public Teacher Teacher { get; set; }

    }
}