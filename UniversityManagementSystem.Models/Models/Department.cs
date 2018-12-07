using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Fild Is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code Fild Is Required")]
        [StringLength(7, MinimumLength = 2)]
        public string Code { get; set; }
       [System.ComponentModel.DefaultValue("false")]
        public bool DeletualStatus { get; set; }
        [NotMapped]
        public List<Department> DepartmentList { get; set; }
    }
}