using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models.Models
{
    public class EnrollStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollDate { get; set; }
        public string Result { get; set; }
        [DefaultValue("false")]
        public bool DeletualStatus { get; set; }
    }
}