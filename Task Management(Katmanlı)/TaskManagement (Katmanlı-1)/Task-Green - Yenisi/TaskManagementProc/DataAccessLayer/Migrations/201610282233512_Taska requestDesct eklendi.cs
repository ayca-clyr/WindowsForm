namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskarequestDescteklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taskks", "RequestTypeDescription", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Taskks", "RequestTypeDescription");
        }
    }
}
