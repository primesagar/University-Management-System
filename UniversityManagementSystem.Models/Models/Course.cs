using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models.Models
{
    public class Course
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
        [DefaultValue ("false")]
        public bool DeletualStatus { get; set; }
        //public List<Student> Students { get; set; }
        //[NotMapped]
        //public List<SelectListItem> TakingAllDeprtment { get; set; }
    }
}