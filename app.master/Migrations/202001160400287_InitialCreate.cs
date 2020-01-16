namespace app.master.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductCategory",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryId, t.ProductId })
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 55),
                        Code = c.String(maxLength: 7),
                        QuantityPerUnit = c.Int(),
                        UnitPrice = c.Double(nullable: false),
                        UnitInStock = c.Int(nullable: false),
                        UnitOrders = c.Int(),
                        Discontinued = c.Boolean(nullable: false),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.OrderProduct",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.ProductId })
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ShippedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        ShipVia = c.String(),
                        ShipAdress = c.String(nullable: false, unicode: false, storeType: "text"),
                        State = c.String(),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderProduct", "ProductId", "dbo.Product");
            DropForeignKey("dbo.OrderProduct", "OrderId", "dbo.Order");
            DropForeignKey("dbo.ProductCategory", "ProductId", "dbo.Product");
            DropForeignKey("dbo.ProductCategory", "CategoryId", "dbo.Category");
            DropIndex("dbo.OrderProduct", new[] { "ProductId" });
            DropIndex("dbo.OrderProduct", new[] { "OrderId" });
            DropIndex("dbo.ProductCategory", new[] { "ProductId" });
            DropIndex("dbo.ProductCategory", new[] { "CategoryId" });
            DropTable("dbo.Order");
            DropTable("dbo.OrderProduct");
            DropTable("dbo.Product");
            DropTable("dbo.ProductCategory");
            DropTable("dbo.Category");
        }
    }
}
