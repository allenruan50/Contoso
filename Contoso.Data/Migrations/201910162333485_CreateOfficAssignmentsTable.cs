namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOfficAssignmentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        InstructorId = c.Int(nullable: false),
                        Location = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.InstructorId)
                .ForeignKey("dbo.Instructors", t => t.InstructorId)
                .Index(t => t.InstructorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorId" });
            DropTable("dbo.OfficeAssignments");
        }
    }
}
