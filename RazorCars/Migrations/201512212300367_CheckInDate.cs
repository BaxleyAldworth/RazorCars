namespace RazorCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckInDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentalHistories", "CheckInDate", c => c.DateTime());
            DropColumn("dbo.RentalHistories", "IsReturned");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RentalHistories", "IsReturned", c => c.Boolean(nullable: false));
            DropColumn("dbo.RentalHistories", "CheckInDate");
        }
    }
}
