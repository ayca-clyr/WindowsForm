namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ideklendi : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Projects", name: "situaition_SituationID", newName: "SituaitionID");
            RenameIndex(table: "dbo.Projects", name: "IX_situaition_SituationID", newName: "IX_SituaitionID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Projects", name: "IX_SituaitionID", newName: "IX_situaition_SituationID");
            RenameColumn(table: "dbo.Projects", name: "SituaitionID", newName: "situaition_SituationID");
        }
    }
}
