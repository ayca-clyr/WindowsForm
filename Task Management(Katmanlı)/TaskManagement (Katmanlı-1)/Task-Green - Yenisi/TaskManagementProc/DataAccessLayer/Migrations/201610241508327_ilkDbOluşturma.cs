namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilkDbOluşturma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        AccountTypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.AccountTypeID);
            
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
                .PrimaryKey(t => t.CustomerRequestID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Description = c.String(nullable: false, unicode: false),
                        EmployeeID = c.Int(nullable: false),
                        ProjectStatus = c.Boolean(),
                        CustomerID = c.Int(nullable: false),
                        GenerateDate = c.DateTime(nullable: false),
                        DeadLine = c.DateTime(nullable: false),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        ContactName = c.String(nullable: false, maxLength: 50, unicode: false),
                        CompanyName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        AcoountTypeID = c.Int(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 25, unicode: false),
                        Email = c.String(nullable: false, maxLength: 80, unicode: false),
                        Password = c.String(nullable: false, maxLength: 80, unicode: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.AccountTypes", t => t.AcoountTypeID, cascadeDelete: true)
                .Index(t => t.AcoountTypeID);
            
            CreateTable(
                "dbo.Situaitions",
                c => new
                    {
                        SituationID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.SituationID);
            
            CreateTable(
                "dbo.Taskks",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, unicode: false),
                        Description = c.String(nullable: false, unicode: false),
                        ProjectID = c.Int(nullable: false),
                        SituaitionID = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        EmployeeID = c.Int(),
                        ManagerID = c.Int(nullable: false),
                        CustomerRequest_CustomerRequestID = c.Int(),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.CustomerRequests", t => t.CustomerRequest_CustomerRequestID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Employees", t => t.ManagerID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .ForeignKey("dbo.Situaitions", t => t.SituaitionID, cascadeDelete: true)
                .Index(t => t.ProjectID)
                .Index(t => t.SituaitionID)
                .Index(t => t.EmployeeID)
                .Index(t => t.ManagerID)
                .Index(t => t.CustomerRequest_CustomerRequestID);
            
            CreateTable(
                "dbo.EmployeeProjects",
                c => new
                    {
                        Employee_EmployeeID = c.Int(nullable: false),
                        Project_ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_EmployeeID, t.Project_ProjectID })
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectID, cascadeDelete: true)
                .Index(t => t.Employee_EmployeeID)
                .Index(t => t.Project_ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Taskks", "SituaitionID", "dbo.Situaitions");
            DropForeignKey("dbo.Taskks", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Taskks", "ManagerID", "dbo.Employees");
            DropForeignKey("dbo.Taskks", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Taskks", "CustomerRequest_CustomerRequestID", "dbo.CustomerRequests");
            DropForeignKey("dbo.CustomerRequests", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Projects", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeProjects", "Project_ProjectID", "dbo.Projects");
            DropForeignKey("dbo.EmployeeProjects", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "AcoountTypeID", "dbo.AccountTypes");
            DropForeignKey("dbo.Projects", "CustomerID", "dbo.Customers");
            DropIndex("dbo.EmployeeProjects", new[] { "Project_ProjectID" });
            DropIndex("dbo.EmployeeProjects", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.Taskks", new[] { "CustomerRequest_CustomerRequestID" });
            DropIndex("dbo.Taskks", new[] { "ManagerID" });
            DropIndex("dbo.Taskks", new[] { "EmployeeID" });
            DropIndex("dbo.Taskks", new[] { "SituaitionID" });
            DropIndex("dbo.Taskks", new[] { "ProjectID" });
            DropIndex("dbo.Employees", new[] { "AcoountTypeID" });
            DropIndex("dbo.Projects", new[] { "CustomerID" });
            DropIndex("dbo.Projects", new[] { "EmployeeID" });
            DropIndex("dbo.CustomerRequests", new[] { "ProjectID" });
            DropTable("dbo.EmployeeProjects");
            DropTable("dbo.Taskks");
            DropTable("dbo.Situaitions");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Projects");
            DropTable("dbo.CustomerRequests");
            DropTable("dbo.AccountTypes");
        }
    }
}
