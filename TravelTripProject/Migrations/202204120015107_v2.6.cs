namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v26 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "NameSurname", c => c.String(nullable: false));
            AddColumn("dbo.Contact", "Subject", c => c.String(nullable: false));
            AddColumn("dbo.Contact", "Message", c => c.String(nullable: false, maxLength: 500));
            DropColumn("dbo.Contact", "AdSoyad");
            DropColumn("dbo.Contact", "Konu");
            DropColumn("dbo.Contact", "Mesaj");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contact", "Mesaj", c => c.String(nullable: false, maxLength: 500));
            AddColumn("dbo.Contact", "Konu", c => c.String(nullable: false));
            AddColumn("dbo.Contact", "AdSoyad", c => c.String(nullable: false));
            DropColumn("dbo.Contact", "Message");
            DropColumn("dbo.Contact", "Subject");
            DropColumn("dbo.Contact", "NameSurname");
        }
    }
}
