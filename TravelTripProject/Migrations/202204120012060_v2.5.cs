namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v25 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Yorum", newName: "Comment");
            RenameTable(name: "dbo.Hakkimizda", newName: "About");
            RenameTable(name: "dbo.Iletisim", newName: "Contact");
            DropTable("dbo.Adres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        AdresAcik = c.String(),
                        Mail = c.String(),
                        Telefon = c.String(),
                        Subjectm = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            RenameTable(name: "dbo.Contact", newName: "Iletisim");
            RenameTable(name: "dbo.About", newName: "Hakkimizda");
            RenameTable(name: "dbo.Comment", newName: "Yorum");
        }
    }
}
