namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class purchase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        Date = c.String(),
                        Supplier = c.String(),
                        FSNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "BookId", "dbo.Books");
            DropIndex("dbo.Purchases", new[] { "BookId" });
            DropTable("dbo.Purchases");
        }
    }
}
