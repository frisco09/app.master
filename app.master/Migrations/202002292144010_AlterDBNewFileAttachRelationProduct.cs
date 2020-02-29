namespace app.master.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterDBNewFileAttachRelationProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FileAttach",
                c => new
                    {
                        FileAttachId = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false),
                        Size = c.Long(nullable: false),
                        FileName = c.String(),
                        Store = c.String(),
                        Type = c.Int(nullable: false),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.FileAttachId)
                .ForeignKey("dbo.Product", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FileAttach", "Product_ProductId", "dbo.Product");
            DropIndex("dbo.FileAttach", new[] { "Product_ProductId" });
            DropTable("dbo.FileAttach");
        }
    }
}
