using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.DatabaseContext;
using UniversityManagementSystem.Models.Models;

namespace UniversityManagementSystem.Repositories.Repositories
{
    public class CourseRepository
    {
        readonly UniversityDBContext _universityDB = new UniversityDBContext();
        public List<Department> AllDepartment()
        {
            return _universityDB.Departments.ToList();
        }

        public List<Semester> AllSemester()
        {
            return _universityDB.Semesters.ToList();
        }
        public List<Teacher> AllTeacher()
        {
            return _universityDB.Teachers.ToList();
        }
        public List<Course> AllCourse()
        {
            //not working
            return _universityDB.Courses.ToList();
            //return _universityDB.Courses.ToList();
        }
        public List<Course> AllCourseTS()
        {
            //not working
            return _universityDB.Courses.Include("Teacher").Include( "Semester").ToList();
            //return _universityDB.Courses.ToList();
        }

        // _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(i => i.Id == id);

        //public List<Course> CourseStatists()
        //{
        //    var cs = (from c in _universityDB.Courses
        //              join s in _universityDB.Semesters on c.SemesterId equals s.Id.ToString()
        //              join t in _universityDB.Teachers on c.TeacherId equals t.Id
        //              select new{
        //                  c.Id,
        //                  c.Name,
        //                  c.Code,
        //                  s.SemesterName

        //                }).ToList();
        //    return cs;
        //}


        public bool AddCourse(Course course)
        {
            var t =_universityDB.Courses.Add(course);
            var y = _universityDB.SaveChanges();
            return y > 0;
        }

        public bool UpdateCourseById(Course course)
        {
            var assignCourse = (from c in _universityDB.Courses where c.Id == course.Id select c).Single();
            assignCourse.TeacherId = course.TeacherId;
            return _universityDB.SaveChanges() > 0;
        }
    }
}
