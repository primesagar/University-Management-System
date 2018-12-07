namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UseSomeAnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AllocateClassRooms", "DeletualStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ClassRooms", "DeletualStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Courses", "Code", c => c.String(maxLength: 10));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Semester", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "DeletualStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Departments", "Code", c => c.String(nullable: false, maxLength: 7));
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "DeletualStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.EnrollStudents", "DeletualStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "RegNo", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "DeletualStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Teachers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "DeletualStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "DeletualStatus", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "Email", c => c.String());
            AlterColumn("dbo.Teachers", "Name", c => c.String());
            AlterColumn("dbo.Students", "DeletualStatus", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "RegNo", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.EnrollStudents", "DeletualStatus", c => c.Int(nullable: false));
            AlterColumn("dbo.Departments", "DeletualStatus", c => c.Int(nullable: false));
            AlterColumn("dbo.Departments", "Name", c => c.String());
            AlterColumn("dbo.Departments", "Code", c => c.String());
            AlterColumn("dbo.Courses", "DeletualStatus", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "Semester", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            AlterColumn("dbo.Courses", "Code", c => c.String());
            AlterColumn("dbo.ClassRooms", "DeletualStatus", c => c.Int(nullable: false));
            AlterColumn("dbo.AllocateClassRooms", "DeletualStatus", c => c.Int(nullable: false));
        }
    }
}
