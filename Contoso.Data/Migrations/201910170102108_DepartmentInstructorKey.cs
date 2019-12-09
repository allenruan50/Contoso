namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentInstructorKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "InstructorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "InstructorId");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors", "Id");
            DropColumn("dbo.Departments", "InsctructorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "InsctructorId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.Departments", new[] { "InstructorId" });
            DropColumn("dbo.Departments", "InstructorId");
        }
    }
}
