namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blog", "Date", c => c.DateTime());
            AddColumn("dbo.Comment", "Username", c => c.String());
            AddColumn("dbo.Comment", "CommentText", c => c.String());
            AddColumn("dbo.Comment", "Date", c => c.DateTime());
            AddColumn("dbo.Contact", "Date", c => c.DateTime());
            DropColumn("dbo.Blog", "Tarih");
            DropColumn("dbo.Comment", "KullaniciAdi");
            DropColumn("dbo.Comment", "YapilanComment");
            DropColumn("dbo.Comment", "Tarih");
            DropColumn("dbo.Contact", "Tarih");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contact", "Tarih", c => c.DateTime());
            AddColumn("dbo.Comment", "Tarih", c => c.DateTime());
            AddColumn("dbo.Comment", "YapilanComment", c => c.String());
            AddColumn("dbo.Comment", "KullaniciAdi", c => c.String());
            AddColumn("dbo.Blog", "Tarih", c => c.DateTime());
            DropColumn("dbo.Contact", "Date");
            DropColumn("dbo.Comment", "Date");
            DropColumn("dbo.Comment", "CommentText");
            DropColumn("dbo.Comment", "Username");
            DropColumn("dbo.Blog", "Date");
        }
    }
}
