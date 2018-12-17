using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Models.Models
{
    public class Semester
    {
        public int Id{ get; set; }
        public string SemesterName { get; set; }
        public ICollection<Course> Course { get; set; }
        [NotMapped]
        public List<Semester> SemesterList { get; set; }

        //public Semester()
        //{

        //    Course = new Collection<Course>();
        //}
    }
}
