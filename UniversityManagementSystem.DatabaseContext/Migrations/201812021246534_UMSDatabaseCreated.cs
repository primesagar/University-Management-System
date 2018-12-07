namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UMSDatabaseCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllocateClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassDay = c.String(),
                        ClassFrom = c.Time(nullable: false, precision: 7),
                        ClassTo = c.Time(nullable: false, precision: 7),
                        DepartmentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        ClassRoomId = c.Int(nullable: false),
                        DeletualStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNo = c.String(),
                        DeletualStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Credit = c.Int(nullable: false),
                        Description = c.String(),
                        Semester = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        DeletualStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        DeletualStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EnrollStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        EnrollDate = c.DateTime(nullable: false),
                        Result = c.String(),
                        DeletualStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        RegNo = c.String(),
                        DateOfRegistration = c.DateTime(nullable: false),
                        Address = c.String(),
                        DepartmentId = c.String(),
                        DeletualStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        Designation = c.String(),
                        CreditLimit = c.String(),
                        DepartmentId = c.String(),
                        DeletualStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.EnrollStudents");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
            DropTable("dbo.ClassRooms");
            DropTable("dbo.AllocateClassRooms");
        }
    }
}
