namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerClassınaHerhangibişeyEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "herhangiBişey", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "herhangiBişey");
        }
    }
}
