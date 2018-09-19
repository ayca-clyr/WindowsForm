namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerRequestkaldırıldı : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmployeeProjects", newName: "ProjectEmployees");
            DropForeignKey("dbo.CustomerRequests", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Taskks", "CustomerRequest_CustomerRequestID", "dbo.CustomerRequests");
            DropIndex("dbo.CustomerRequests", new[] { "ProjectID" });
            DropIndex("dbo.Taskks", new[] { "CustomerRequest_CustomerRequestID" });
            DropPrimaryKey("dbo.ProjectEmployees");
            AddColumn("dbo.Projects", "RequestType", c => c.String(maxLength: 25, unicode: false));
            AddPrimaryKey("dbo.ProjectEmployees", new[] { "Project_ProjectID", "Employee_EmployeeID" });
            DropColumn("dbo.Taskks", "CustomerRequest_CustomerRequestID");
            DropTable("dbo.CustomerRequests");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CustomerRequests",
                c => new
                    {
                        CustomerRequestID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                        Description = c.String(nullable: false, unicode: false),
                        RequestType = c.Boolean(nullable: false),
                        RequestDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerRequestID);
            
            AddColumn("dbo.Taskks", "CustomerRequest_CustomerRequestID", c => c.Int());
            DropPrimaryKey("dbo.ProjectEmployees");
            DropColumn("dbo.Projects", "RequestType");
            AddPrimaryKey("dbo.ProjectEmployees", new[] { "Employee_EmployeeID", "Project_ProjectID" });
            CreateIndex("dbo.Taskks", "CustomerRequest_CustomerRequestID");
            CreateIndex("dbo.CustomerRequests", "ProjectID");
            AddForeignKey("dbo.Taskks", "CustomerRequest_CustomerRequestID", "dbo.CustomerRequests", "CustomerRequestID");
            AddForeignKey("dbo.CustomerRequests", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete: true);
            RenameTable(name: "dbo.ProjectEmployees", newName: "EmployeeProjects");
        }
    }
}
