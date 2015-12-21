namespace RazorCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentalHistoryAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentalHistories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalSupply = c.Int(nullable: false),
                        AvailableForRent = c.Int(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        IsReturned = c.Boolean(nullable: false),
                        Inventory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Inventories", t => t.Inventory_ID)
                .Index(t => t.Inventory_ID);
            
            AddColumn("dbo.Inventories", "StoreModel", c => c.Int(nullable: false));
            DropColumn("dbo.Inventories", "AvailableForRent");
            DropColumn("dbo.Inventories", "CheckOutDate");
            DropColumn("dbo.Inventories", "IsReturned");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inventories", "IsReturned", c => c.Boolean(nullable: false));
            AddColumn("dbo.Inventories", "CheckOutDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Inventories", "AvailableForRent", c => c.Int(nullable: false));
            DropForeignKey("dbo.RentalHistories", "Inventory_ID", "dbo.Inventories");
            DropIndex("dbo.RentalHistories", new[] { "Inventory_ID" });
            DropColumn("dbo.Inventories", "StoreModel");
            DropTable("dbo.RentalHistories");
        }
    }
}
