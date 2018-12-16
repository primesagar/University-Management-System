namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSemesterModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SemesterName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "SemesterId", c => c.String(nullable: false));
            DropColumn("dbo.Courses", "Semester");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Semester", c => c.String(nullable: false));
            DropColumn("dbo.Courses", "SemesterId");
            DropTable("dbo.Semesters");
        }
    }
}
