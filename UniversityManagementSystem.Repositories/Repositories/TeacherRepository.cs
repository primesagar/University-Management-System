using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.DatabaseContext;
using UniversityManagementSystem.Models.Models;

namespace UniversityManagementSystem.Repositories.Repositories
{
     public class TeacherRepository
    {
        readonly UniversityDBContext _universityDB = new UniversityDBContext();

        public List<Department> AllDepartment()
        {
            return _universityDB.Departments.ToList();
        }
        public List<Designation> AllDesignation()
        {
            return _universityDB.Designations.ToList();
        }
        public bool SaveTeacher(Teacher teacher)
        {
            _universityDB.Teachers.Add(teacher);
            return _universityDB.SaveChanges() > 0;
        }
    }
}
