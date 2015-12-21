namespace RazorCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoreName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stores", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stores", "Name");
        }
    }
}
