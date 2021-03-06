USE [alfa_v2_ef_red_db]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AccountTypes]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountTypes](
	[AccountTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.AccountTypes] PRIMARY KEY CLUSTERED 
(
	[AccountTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerRequests]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerRequests](
	[CustomerRequestID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NOT NULL,
	[Description] [varchar](8000) NOT NULL,
	[RequestType] [bit] NOT NULL,
	[RequestDate] [date] NOT NULL,
 CONSTRAINT [PK_dbo.CustomerRequests] PRIMARY KEY CLUSTERED 
(
	[CustomerRequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[ContactName] [varchar](50) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Address] [varchar](8000) NOT NULL,
	[Email] [varchar](8000) NOT NULL,
	[LogoURL] [varchar](8000) NULL,
	[GSM] [char](16) NOT NULL,
	[isPassive] [bit] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[AccountTypeID] [int] NOT NULL,
	[GSM] [char](16) NOT NULL,
	[Email] [varchar](8000) NOT NULL,
	[Password] [varchar](16) NOT NULL,
	[ImageURL] [varchar](8000) NULL,
 CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectEmployees]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectEmployees](
	[ProjectID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.ProjectEmployees] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC,
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Projects]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TeamLeadID] [int] NOT NULL,
	[GenerateDate] [date] NOT NULL,
	[DeadLine] [date] NOT NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[IsCancel] [bit] NOT NULL,
	[IsFinish] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Situaitions]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Situaitions](
	[SituationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.Situaitions] PRIMARY KEY CLUSTERED 
(
	[SituationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 31.10.2016 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tasks](
	[TaskID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[ProjectID] [int] NOT NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NOT NULL,
	[SituaitionID] [int] NOT NULL,
	[ManagerID] [int] NOT NULL,
	[EmployeeID] [int] NULL,
	[isFinish] [bit] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_dbo.Tasks] PRIMARY KEY CLUSTERED 
(
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CustomerRequests]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CustomerRequests_dbo.Projects_ProjectID] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Projects] ([ProjectID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerRequests] CHECK CONSTRAINT [FK_dbo.CustomerRequests_dbo.Projects_ProjectID]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Employees_dbo.AccountTypes_AccountTypeID] FOREIGN KEY([AccountTypeID])
REFERENCES [dbo].[AccountTypes] ([AccountTypeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_dbo.Employees_dbo.AccountTypes_AccountTypeID]
GO
ALTER TABLE [dbo].[ProjectEmployees]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProjectEmployees_dbo.Employees_EmployeeID] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[ProjectEmployees] CHECK CONSTRAINT [FK_dbo.ProjectEmployees_dbo.Employees_EmployeeID]
GO
ALTER TABLE [dbo].[ProjectEmployees]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProjectEmployees_dbo.Projects_ProjectID] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Projects] ([ProjectID])
GO
ALTER TABLE [dbo].[ProjectEmployees] CHECK CONSTRAINT [FK_dbo.ProjectEmployees_dbo.Projects_ProjectID]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Projects_dbo.Customers_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_dbo.Projects_dbo.Customers_CustomerID]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Projects_dbo.Employees_EmployeeID] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_dbo.Projects_dbo.Employees_EmployeeID]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Projects_dbo.Employees_TeamLeadID] FOREIGN KEY([TeamLeadID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_dbo.Projects_dbo.Employees_TeamLeadID]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tasks_dbo.Employees_EmployeeID] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_dbo.Tasks_dbo.Employees_EmployeeID]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tasks_dbo.Employees_ManagerID] FOREIGN KEY([ManagerID])
REFERENCES [dbo].[Employees] ([EmployeeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_dbo.Tasks_dbo.Employees_ManagerID]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tasks_dbo.Projects_ProjectID] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Projects] ([ProjectID])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_dbo.Tasks_dbo.Projects_ProjectID]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tasks_dbo.Situaitions_SituaitionID] FOREIGN KEY([SituaitionID])
REFERENCES [dbo].[Situaitions] ([SituationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_dbo.Tasks_dbo.Situaitions_SituaitionID]
GO
