namespace RazorCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedRentalHistorySupply : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RentalHistories", "TotalSupply");
            DropColumn("dbo.RentalHistories", "AvailableForRent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RentalHistories", "AvailableForRent", c => c.Int(nullable: false));
            AddColumn("dbo.RentalHistories", "TotalSupply", c => c.Int(nullable: false));
        }
    }
}
