using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.DatabaseContext;
using UniversityManagementSystem.Models.Models;

namespace UniversityManagementSystem.Repositories.Repositories
{
    public class DepartmentRepository
    {
        readonly UniversityDBContext _universityDB = new UniversityDBContext();

        public bool AddDepartment(Department department)
        {
            _universityDB.Departments.Add(department);
            return _universityDB.SaveChanges() > 0;
        }

        public List<Department> ShowDepartment()
        {
            //return _universityDB.Departments.FirstOrDefault(d => d.DeletualStatus == false).ToList();
            return _universityDB.Departments.ToList();

        }

        //public void ShowDepartment()
        //{
        //    _universityDBContext.Departments.Select
        //}
    }
}
