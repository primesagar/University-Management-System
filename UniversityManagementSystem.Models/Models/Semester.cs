using System;
using System.Collections.Generic;
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
        [NotMapped]
        public List<Semester> SemesterList { get; set; }
    }
}
