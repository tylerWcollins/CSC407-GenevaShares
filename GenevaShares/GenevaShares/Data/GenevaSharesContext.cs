namespace GenevaShares.Data
{
    using GenevaShares.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GenevaSharesContext : DbContext
    {
        // Your context has been configured to use a 'GenevaSharesContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GenevaShares.Data.GenevaSharesContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GenevaSharesContext' 
        // connection string in the application configuration file.
        public GenevaSharesContext()
            : base("name=GenevaSharesContext")
        {
            Database.SetInitializer<GenevaSharesContext>(new CreateDatabaseIfNotExists<GenevaSharesContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

}