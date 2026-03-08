namespace BrouwerijWittig.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Guid(nullable: false),
                        ProductName = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Expirationdate = c.DateTime(),
                        Origin = c.String(),
                        AlcoholPercentage = c.Decimal(precision: 18, scale: 2),
                        Content = c.Decimal(precision: 18, scale: 2),
                        BrandName = c.String(),
                        AmountInStock = c.Int(),
                        InStock = c.Boolean(),
                        FactoryOrdered = c.Boolean(),
                        BackInStock = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Beers_ProductId = c.Guid(),
                        Brand_ProductId = c.Guid(),
                        Category_CategoryId = c.Guid(),
                        Beer_ProductId = c.Guid(),
                        Stock_ProductId = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Products", t => t.Beers_ProductId)
                .ForeignKey("dbo.Products", t => t.Brand_ProductId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .ForeignKey("dbo.Products", t => t.Beer_ProductId)
                .ForeignKey("dbo.Products", t => t.Stock_ProductId)
                .Index(t => t.Beers_ProductId)
                .Index(t => t.Brand_ProductId)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Beer_ProductId)
                .Index(t => t.Stock_ProductId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Guid(nullable: false),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Stock_ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "Beer_ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "Brand_ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "Beers_ProductId", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Stock_ProductId" });
            DropIndex("dbo.Products", new[] { "Beer_ProductId" });
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropIndex("dbo.Products", new[] { "Brand_ProductId" });
            DropIndex("dbo.Products", new[] { "Beers_ProductId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
        }
    }
}
