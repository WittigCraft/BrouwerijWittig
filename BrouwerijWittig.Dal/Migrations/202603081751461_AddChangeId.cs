namespace BrouwerijWittig.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChangeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Beers_ProductId", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Beers_ProductId" });
            AddColumn("dbo.Products", "GuidId", c => c.Guid(nullable: false));
            DropColumn("dbo.Products", "Beers_ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Beers_ProductId", c => c.Guid());
            DropColumn("dbo.Products", "GuidId");
            CreateIndex("dbo.Products", "Beers_ProductId");
            AddForeignKey("dbo.Products", "Beers_ProductId", "dbo.Products", "ProductId");
        }
    }
}
