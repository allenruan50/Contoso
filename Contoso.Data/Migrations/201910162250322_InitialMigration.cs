namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        MUnitOrApartmentNumber = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Password = c.String(),
                        Salt = c.String(),
                        IsLocked = c.String(),
                        LastLockedDateTime = c.DateTime(nullable: false),
                        FailedAttempts = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
