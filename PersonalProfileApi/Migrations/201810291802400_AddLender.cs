namespace PersonalProfileApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLender : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lenders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Email = c.String(nullable: false),
                        MobileNo = c.String(nullable: false, maxLength: 12),
                        AlternateMobileNo = c.String(maxLength: 12),
                        Address = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lenders");
        }
    }
}
