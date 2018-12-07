using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Designation { get; set; }
        public string CreditLimit { get; set; }
        public string DepartmentId { get; set; }
        [DefaultValue("false")]
        public bool DeletualStatus { get; set; }
    }
}