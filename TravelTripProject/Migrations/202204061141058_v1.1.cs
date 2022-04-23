namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "Username", c => c.String());
            DropColumn("dbo.Comment", "KulaniciAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comment", "KulaniciAdi", c => c.String());
            DropColumn("dbo.Comment", "Username");
        }
    }
}
