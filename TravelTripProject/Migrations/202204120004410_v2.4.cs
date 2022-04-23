namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v24 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adres", "Title", c => c.String());
            AddColumn("dbo.Blog", "Title", c => c.String());
            DropColumn("dbo.Adres", "Baslik");
            DropColumn("dbo.Blog", "Baslik");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blog", "Baslik", c => c.String());
            AddColumn("dbo.Adres", "Baslik", c => c.String());
            DropColumn("dbo.Blog", "Title");
            DropColumn("dbo.Adres", "Title");
        }
    }
}
