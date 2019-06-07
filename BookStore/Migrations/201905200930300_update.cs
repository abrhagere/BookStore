namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Book_Title", c => c.String());
            AddColumn("dbo.Customers", "Customer_Name", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            DropColumn("dbo.Books", "title");
            DropColumn("dbo.Customers", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "FullName", c => c.String());
            AddColumn("dbo.Books", "title", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "Customer_Name");
            DropColumn("dbo.Books", "Book_Title");
        }
    }
}
