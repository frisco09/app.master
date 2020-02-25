namespace app.master.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterProductSetRelationFileAttach : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "FileAttachId", c => c.Int());
            CreateIndex("dbo.Product", "FileAttachId");
            AddForeignKey("dbo.Product", "FileAttachId", "dbo.FileAttach", "FileAttachId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "FileAttachId", "dbo.FileAttach");
            DropIndex("dbo.Product", new[] { "FileAttachId" });
            DropColumn("dbo.Product", "FileAttachId");
        }
    }
}
