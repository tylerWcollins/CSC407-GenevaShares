namespace GenevaShares.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Postings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        NewId = c.Int(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Nickname = c.String(),
                    })
                .PrimaryKey(t => t.NewId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Postings");
        }
    }
}
