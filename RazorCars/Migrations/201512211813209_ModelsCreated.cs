namespace RazorCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsCreated : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AspNetUsers", name: "StoreID_StoreID", newName: "Store_StoreID");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_StoreID_StoreID", newName: "IX_Store_StoreID");
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalSupply = c.Int(nullable: false),
                        AvailableForRent = c.Int(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        IsReturned = c.Boolean(nullable: false),
                        CarType_ID = c.Int(),
                        Store_StoreID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cars", t => t.CarType_ID)
                .ForeignKey("dbo.Stores", t => t.Store_StoreID)
                .Index(t => t.CarType_ID)
                .Index(t => t.Store_StoreID);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ModelYear = c.String(),
                        Manufacturer = c.String(),
                        CarModel = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventories", "Store_StoreID", "dbo.Stores");
            DropForeignKey("dbo.Inventories", "CarType_ID", "dbo.Cars");
            DropIndex("dbo.Inventories", new[] { "Store_StoreID" });
            DropIndex("dbo.Inventories", new[] { "CarType_ID" });
            DropTable("dbo.Cars");
            DropTable("dbo.Inventories");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_Store_StoreID", newName: "IX_StoreID_StoreID");
            RenameColumn(table: "dbo.AspNetUsers", name: "Store_StoreID", newName: "StoreID_StoreID");
        }
    }
}
