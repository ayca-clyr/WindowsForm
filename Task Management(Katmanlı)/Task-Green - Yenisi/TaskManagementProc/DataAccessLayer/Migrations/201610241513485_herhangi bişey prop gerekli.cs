namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class herhangibişeypropgerekli : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "herhangiBişey", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "herhangiBişey", c => c.String());
        }
    }
}
