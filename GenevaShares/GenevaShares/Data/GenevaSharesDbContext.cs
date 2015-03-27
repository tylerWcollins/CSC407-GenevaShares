namespace GenevaShares.Data
{
    using GenevaShares.Migrations;
    using GenevaShares.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GenevaSharesDbContext : DbContext
    {
        // Your context has been configured to use a 'GenevaSharesDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GenevaShares.Data.GenevaSharesDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GenevaSharesDbContext' 
        // connection string in the application configuration file.
        public GenevaSharesDbContext()
            : base("name=GenevaSharesDbContext")
        {
            Database.SetInitializer<GenevaSharesDbContext>(new CreateDatabaseIfNotExists<GenevaSharesDbContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Posting> Postings { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}