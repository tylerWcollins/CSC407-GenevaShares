namespace GenevaShares.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Relationship_Between_Posting_And_Like : DbMigration
    {
        
        public override void Up()
        {
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Posting_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postings", t => t.Posting_Id, cascadeDelete: true)
                .Index(t => t.Posting_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Likes", "Posting_Id", "dbo.Postings");
            DropIndex("dbo.Likes", new[] { "Posting_Id" });
            DropTable("dbo.Likes");
        }
    }
}
