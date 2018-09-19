namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class herhangibirsey : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "herhangiBişey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "herhangiBişey", c => c.String(nullable: false));
        }
    }
}
