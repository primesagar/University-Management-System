using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models.Models
{
    public class AllocateClassRoom
    {
        public int Id { get; set; }
        public string ClassDay { get; set; }
        public TimeSpan ClassFrom { get; set; }
        public TimeSpan ClassTo { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public int ClassRoomId { get; set; }
        [System.ComponentModel.DefaultValue("false")]
        public bool DeletualStatus { get; set; }
    }
}