namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entitiyprojecysitationeklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "situaition_SituationID", c => c.Int());
            CreateIndex("dbo.Projects", "situaition_SituationID");
            AddForeignKey("dbo.Projects", "situaition_SituationID", "dbo.Situaitions", "SituationID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "situaition_SituationID", "dbo.Situaitions");
            DropIndex("dbo.Projects", new[] { "situaition_SituationID" });
            DropColumn("dbo.Projects", "situaition_SituationID");
        }
    }
}
