using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.DatabaseContext;
using UniversityManagementSystem.Models.Models;

namespace UniversityManagementSystem.Repositories
{
    public class StudentRepository { 

        readonly UniversityDBContext _universityDB = new UniversityDBContext();
    public List<Department> AllDepatrmint()
        {
            return _universityDB.Departments.ToList();
        }
    }
}
