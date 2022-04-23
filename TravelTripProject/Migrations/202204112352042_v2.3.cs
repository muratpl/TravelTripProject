namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v23 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adres", "Description", c => c.String());
            AddColumn("dbo.Blog", "Description", c => c.String());
            AddColumn("dbo.About", "ImageUrl", c => c.String());
            AddColumn("dbo.About", "Description", c => c.String());
            DropColumn("dbo.Adres", "Aciklama");
            DropColumn("dbo.Blog", "Aciklama");
            DropColumn("dbo.About", "FotoUrl");
            DropColumn("dbo.About", "Aciklama");
        }
        
        public override void Down()
        {
            AddColumn("dbo.About", "Aciklama", c => c.String());
            AddColumn("dbo.About", "FotoUrl", c => c.String());
            AddColumn("dbo.Blog", "Aciklama", c => c.String());
            AddColumn("dbo.Adres", "Aciklama", c => c.String());
            DropColumn("dbo.About", "Description");
            DropColumn("dbo.About", "ImageUrl");
            DropColumn("dbo.Blog", "Description");
            DropColumn("dbo.Adres", "Description");
        }
    }
}
