namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Taskk_TaskID", c => c.Int());
            CreateIndex("dbo.Projects", "Taskk_TaskID");
            AddForeignKey("dbo.Projects", "Taskk_TaskID", "dbo.Taskks", "TaskID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "Taskk_TaskID", "dbo.Taskks");
            DropIndex("dbo.Projects", new[] { "Taskk_TaskID" });
            DropColumn("dbo.Projects", "Taskk_TaskID");
        }
    }
}
