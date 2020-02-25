namespace app.master.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFileAttachTable : DbMigration
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
                    })
                .PrimaryKey(t => t.FileAttachId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FileAttach");
        }
    }
}
