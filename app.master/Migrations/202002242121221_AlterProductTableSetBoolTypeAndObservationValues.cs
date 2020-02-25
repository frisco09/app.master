namespace app.master.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterProductTableSetBoolTypeAndObservationValues : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Observation", c => c.String());
            AddColumn("dbo.Product", "AsSale", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "AsInput", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "AsInput");
            DropColumn("dbo.Product", "AsSale");
            DropColumn("dbo.Product", "Observation");
        }
    }
}
