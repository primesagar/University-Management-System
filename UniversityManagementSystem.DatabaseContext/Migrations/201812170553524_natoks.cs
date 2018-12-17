namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class natoks : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "SemesterId", c => c.Int());
            CreateIndex("dbo.Courses", "SemesterId");
            CreateIndex("dbo.Courses", "TeacherId");
            AddForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters", "Id");
            AddForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            AlterColumn("dbo.Courses", "SemesterId", c => c.String(nullable: false));
        }
    }
}
