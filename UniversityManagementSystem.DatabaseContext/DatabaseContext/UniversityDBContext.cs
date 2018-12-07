using System;
using System.Data.Entity;
using UniversityManagementSystem.Models.Models;

namespace UniversityManagementSystem.DatabaseContext
{
    public class UniversityDBContext:DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<AllocateClassRoom> AllocateClassRooms { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EnrollStudent> EnrollStudents { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}