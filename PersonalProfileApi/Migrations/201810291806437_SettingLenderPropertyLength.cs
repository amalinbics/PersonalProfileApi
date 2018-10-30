namespace PersonalProfileApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingLenderPropertyLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lenders", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Lenders", "MiddleName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Lenders", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Lenders", "Email", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lenders", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Lenders", "LastName", c => c.String());
            AlterColumn("dbo.Lenders", "MiddleName", c => c.String());
            AlterColumn("dbo.Lenders", "FirstName", c => c.String(nullable: false));
        }
    }
}
