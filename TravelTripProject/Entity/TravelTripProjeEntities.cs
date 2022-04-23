namespace TravelTripProject.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using TravelTripProject.Models.Siniflar;

    public class TravelTripProjectEntities : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TravelTripProject.Entity.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public TravelTripProjectEntities()
            : base("name=TravelTripProjectEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Administrator> Admin { get; set; }
         public virtual DbSet<Blog> Blog { get; set; }
         public virtual DbSet<About> About { get; set; }
         public virtual DbSet<Contact> Contact { get; set; }
         public virtual DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}