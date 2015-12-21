namespace RazorCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InventoryStore : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Inventories", "StoreModel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inventories", "StoreModel", c => c.Int(nullable: false));
        }
    }
}
