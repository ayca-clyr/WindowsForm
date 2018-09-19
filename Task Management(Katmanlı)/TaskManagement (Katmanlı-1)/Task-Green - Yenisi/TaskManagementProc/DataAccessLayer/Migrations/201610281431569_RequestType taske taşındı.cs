namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequestTypetasketaşındı : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taskks", "RequestType", c => c.String(maxLength: 25, unicode: false));
            DropColumn("dbo.Projects", "RequestType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "RequestType", c => c.String(maxLength: 25, unicode: false));
            DropColumn("dbo.Taskks", "RequestType");
        }
    }
}
