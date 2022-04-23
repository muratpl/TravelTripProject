namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v16 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contact", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contact", "Date", c => c.DateTime(nullable: false));
        }
    }
}
