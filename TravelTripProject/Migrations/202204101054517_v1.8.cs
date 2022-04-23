namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v18 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contact", "NameSurname", c => c.String(nullable: false));
            AlterColumn("dbo.Contact", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Contact", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Contact", "Subject", c => c.String(nullable: false));
            AlterColumn("dbo.Contact", "Message", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contact", "Message", c => c.String());
            AlterColumn("dbo.Contact", "Subject", c => c.String());
            AlterColumn("dbo.Contact", "Phone", c => c.String());
            AlterColumn("dbo.Contact", "Mail", c => c.String());
            AlterColumn("dbo.Contact", "NameSurname", c => c.String());
        }
    }
}
