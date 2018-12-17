using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.MVC.Models
{
    public class StudentRegisterViewModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [MinLength(5)]
        public string Email { get; set; }
        public string Contact { get; set; }
        [Required]
        [MinLength(11)]
        public string RegNo { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string Address { get; set; }
        public string DepartmentId { get; set; }
        [System.ComponentModel.DefaultValue("false")]
        public bool DeletualStatus { get; set; }
        public List<SelectListItem> DepartmentSelectListItems { get; set; }
        //public List<Course> Courses { get; set; }
    }
}