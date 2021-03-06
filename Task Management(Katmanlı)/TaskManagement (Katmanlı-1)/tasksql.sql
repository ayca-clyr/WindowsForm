USE [master]
GO
/****** Object:  Database [TaskManagemenetContext]    Script Date: 5.09.2018 21:08:58 ******/
CREATE DATABASE [TaskManagemenetContext]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TaskManagemenetContext', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TaskManagemenetContext.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TaskManagemenetContext_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TaskManagemenetContext_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TaskManagemenetContext] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TaskManagemenetContext].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TaskManagemenetContext] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET ARITHABORT OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TaskManagemenetContext] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TaskManagemenetContext] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TaskManagemenetContext] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TaskManagemenetContext] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TaskManagemenetContext] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [TaskManagemenetContext] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TaskManagemenetContext] SET  MULTI_USER 
GO
ALTER DATABASE [TaskManagemenetContext] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TaskManagemenetContext] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TaskManagemenetContext] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TaskManagemenetContext] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TaskManagemenetContext] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TaskManagemenetContext]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 5.09.2018 21:08:58 ******/
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
/****** Object:  Table [dbo].[AccountTypes]    Script Date: 5.09.2018 21:08:58 ******/
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
/****** Object:  Table [dbo].[CustomerRequests]    Script Date: 5.09.2018 21:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerRequests](
	[CustomerRequestID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[RequestType] [bit] NOT NULL,
	[RequestDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.CustomerRequests] PRIMARY KEY CLUSTERED 
(
	[CustomerRequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 5.09.2018 21:08:58 ******/
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
	[Address] [varchar](100) NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone] [varchar](25) NOT NULL,
 CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeeProjects]    Script Date: 5.09.2018 21:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeProjects](
	[Employee_EmployeeID] [int] NOT NULL,
	[Project_ProjectID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.EmployeeProjects] PRIMARY KEY CLUSTERED 
(
	[Employee_EmployeeID] ASC,
	[Project_ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 5.09.2018 21:08:58 ******/
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
	[AcoountTypeID] [int] NOT NULL,
	[Phone] [varchar](25) NOT NULL,
	[Email] [varchar](80) NOT NULL,
	[Password] [varchar](80) NOT NULL,
 CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 5.09.2018 21:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ProjectStatus] [bit] NULL,
	[CustomerID] [int] NOT NULL,
	[GenerateDate] [datetime] NOT NULL,
	[DeadLine] [datetime] NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_dbo.Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Situaitions]    Script Date: 5.09.2018 21:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Situaitions](
	[SituationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NOT NULL,
 CONSTRAINT [PK_dbo.Situaitions] PRIMARY KEY CLUSTERED 
(
	[SituationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Taskks]    Script Date: 5.09.2018 21:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Taskks](
	[TaskID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[ProjectID] [int] NOT NULL,
	[SituaitionID] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[EmployeeID] [int] NULL,
	[ManagerID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Taskks] PRIMARY KEY CLUSTERED 
(
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201610232233484_InitialCreate', N'DataAccessLayer.TaskManagemenetContext', 0x1F8B0800000000000400ED1DDB4E24BBF13D52FEA1D54F49C46180D5913668E61C71608950D80531EC51DE90E9364367FB32A7DB434051BE2C0FF9A4FC42DC77DFDB76DF8655B4D20ADA76B95C55AE2A975DC57FFFFD9FE5CFAF51E8BCC0340B9278E51E1F1EB90E8CBDC40FE2CDCADDA1A71F3EBA3FFFF4FBDF2D3FF9D1ABF36BDDEF43DE0F8F8CB395FB8CD0F674B1C8BC671881EC300ABC34C9922774E825D102F8C9E2E4E8E8CF8BE3E305C4205C0CCB719677BB1805112C7EC1BF9E27B107B76807C2CF890FC3ACFA8E5BD60554E70B8860B6051E5CB917008133CF8359760DDE60EA3A676100301A6B183EB90E88E3040184913CFD9AC1354A9378B3DEE20F20BC7FDB42DCEF098419AC903F6DBBEBAEE3E8245FC7A21D5883F276194A224380C71F2AC22CD8E156E4751BC261D27DC224466FF9AA0BF2AD5C4CB504D33DFFE23AEC7CA7E7619AB7ACDC625C00B343A2FF81537F3D688400CB4AFEEFC039DF856897C2550C772805E18173BB7B0C03EFAFF0ED3EF906E355BC0B4312338C1B6EA33EE04FB769B285297ABB834F3CBE5717AEB3A0412C58180D04F1F072715731FA70E23A5F304AE031848D38108458A324857F81314C0182FE2D4008A6989B573E2C08CA21C24C9BFF5FCF86E50FEF23D7F90C5EAF61BC41CF2BF747BC712E8357E8D71F2A04BEC601DE75780C4A7750802039E972D1F256C9F1F382C930BD83BFED6086B4B8CE8C9985F30C0E36DC1780984A02F0AF7F879EC6946A301730F3D2605B2A03A93CE11FFB0B143F7945B652579493FF92242104B12D28ACB71B50F9CFF741A481D617F0126C0AAE8889EC3A77302CDAB3E7605B5A0156841F9ABE976912DD25212F1E75978775B24BBD1CCF44DDEF1EA41B882CB765838FC676ACFACEB20D094136DD7EDA7B6032C57B7C3480E6DDB35DFA29DA86C91BD4B06F5A1A6B8D19B1CBB8FDAE1E5BEF90BE38D48CB7D3131C57807F1DC4FD016192A412D5D5C19AD8D71A265570355D851AAE56436DA756B5B16D9C4EE33A8894990AB55AEC94A8B59D78D4EA36296A4D075BD4B24C885C03576012D8B666EE1A39AE438D7D2FDFCCC8299BD51BEBE3864D6908F06912010F4DE0888BE68EB6207E9B65EE33DF4F0BC1EF6D03BBAC0E08C2C95777FB9CC42A9A9EFC38E1C1AA556E1A9BB7EE3CCBE6255D04D3CDABEF5E0CB7792F83349B67EB5E8399263EF312FD40C5FC9BC45C217C1C4721802CFB4792FAE34F2CF536A8889ACADDA03A0A5C0EA29DF389849D4CFD22D571D9C829926237C8C9781DA01D08CAC39486666DBBCFA25B8BE9F3D96D942B35784FCEC893DAD07B907DFBA6C5E6A2E72C1CCE67B6616E3D6E4FF83A52F861D6D8C74051D65685F486240F1598DA5359EC60A8F0907AD86710838D4540C72E5E506C6E61B4806EE12C0FD36C6A11AB552A706A7AB028550D128CEAD6214D740959609FA90609422ACBAC428834C6529CC84E2C5A6D9B0433A28389DB709665891714F8D0B46BE361F412F18672BA8263A5FA222258588961AB126CB11DC138ACDC3F719453806D62472DD836E043C33D76593B74135FC01022E89C79E54DF239C83CE0F33B0ED3C7A7BF60D305D3DC6680F01C730B1BC32046BC9D0B622FD882B0037B669C617028C7AF99896DB9805B18E7C6AD832FFD5168666248D745A9E5821033B5F409DD7C99A8A87DFE565C5A8DA82F86CAA302019B3A8EEC9B34AA16A1230ECA67034642A962951E26891A932965B3D66A9DB2C319938164920BAB9B6A5C83557397105D8A9BF73206B1079C77A241CC630E6E2FA5CEA2A023B8F2A0A195526789DB1F8509368EEC11818CE59D2F0A784FA07996A32F585DEF11BAC5767E05DFB1061DE990BE4C3092CF0E96F546640229654E4F32B1911DA55A69A9A231FA9228397E6928B8A3C3C381749C188709359C98AEEF42BFD1675C3597B9036F6FB9610FC9D3D945E1FC938B0C43519DF989B0CC8C02D36506250189DE02F31E0D9D10F3E9CC9B9015EFC7A8119125B56888C24CBDE54D109A22809251AFFD943A1E7F1DCE2B6EB42C448F678C360E811C89C105B00C3216AF868218A68410962A3782314479337C15BDD9FD9AC1EACA2AABAE3258C9CAC1AF21E2E31399EBB4114E516C8613521A14E3C08AC071678D0E90D5DE17816AF4AC26562A743A81340FF904405A0FA103482B4A2230E426EE0054C8B30846A55D98E184A0719425DE6C12DD64EF3A59E9D7886437B893CCE4B69146EC9A0044B094555AF45A35E8207E14C1D3A23BAAAA1F5725964208968228CA482A018DDECCC3D1A6D96B0ABA085D31BD989E3D3D583F4C43DA2CE8C03F2296EF15F1E1572FCA67BB57B863AF0E412DE820CD64E1C9A115AF328A5809F67F6B681444EA8A518D2332EC3D324F2155AC44275A42E05DDB03051524F191910485B9B1962D5E78DCD738F0DB2C9D3DE28FBA72C5C6509C5B354EAE362B9F52E0492746B676D9494AEF2C654301C1E9890043B965DA74A85F03348E7AD3B65C9469E2D587E542924FBEFC0CB6DB20DE10F9E5D517675D26979FFFB0364FBC8E4A180B2F13E45F37D83633A124C5FB8269CD33077C583C7ECE13DC1F41FEBEE6DC8FB86E926389C47DAD27159C3C7816D6AE6D3D28FFB97AE845E7DC1F2A3CB296A6977899517E242CDEB6897D267EB493E7FC8310A4F2A7B6F9B1F03C097751AC75E12B8759BE9A2341955F7808CB05B328EE54CA918F3BDBD32CD162186776FB308D3D099A33AE13828CD082646C92EA9DE9DE2AD844B08A84A98861C961510F1A496854833E3C2A8B9A84473518C32B1F070AE0950D7B23BE8DB1EB23B612C3AD21AED291538892BE6E994A18C9FB0B129CEA5EA3935675CAB0805E75933E4CF22197483F986148271493F0E816138ED459C5343BEAAFFA9088B7C22428E2B3015FEBD7C21453EB8F7BA30CDA10D21046AC87F532375BC3C82395964A81231B4CE011A9A6343CA2411F5E933E4AF956F547133D536483D12AA6F864A05DCA3C364AAB949FF6469EDB336C1F7996452334E4593E741A0B40646A92C088CFFAB0DADC4B1254FBD5408AE93797F43941F91C530ED3441A47DD154DC623854AF3756FF60679C0EFB33BE4810B8DFDA11A2CB5CBE4FD2765995517A372787B7FC2AC223A7D98545E8199F347324E46CA3AA58E24A6383D6F18864CE5960F79E8A0AFCE39F9955EAA2B20CEE8A84E63C68867552430C56BABF1372B1D0315FB1D6DC8BBDBBB68FBCA9C0845785C42FDEE874556CC7B5071B178225303B44055FA12C662673E2876A81C4F36BECDB39F0B73B35D1AE16BC2DD4C587B598598BB6BA97231E7B28BEB60DC5F023F8F37AFDF3204A3C3BCC3E1FAB7F03C0CB0B8B71DF036099EF248569166ED9E1C1D9F301559F7A73AEA22CBFC5010A22772D2E5095CB3552C0DE27ADBAAD2C30D33834BA3574EF00252EF19A45CA193714A905A5075CC6AA0A35097D00CC42CDCC3B1ABD887AF2BF79FC5A853E7EA6FAD4A39706E52BCBB4E9D23E75F43A4E5573CFE43045EFF38442DD0C7000D5107D4C73FA3EECC76E3C29A164226D5E616B52E67D9B2456DAF9925852F38A02BF9EDC85EA2CF849E85C2AA53E28C2F5BA7BB907664AF8588AA616AEE16119BE96A98D680B8121722485A25E4E80A177A60CC4B2BF63036C3143B1C451308EA1B5AD9701164AE7AE1409099DA841A0ACCB812E140985225D44430F32249035711B490D361EBFA8D22A75C29BF8138C416EA1B4A444565F874D53E35B89F09EB2D7F16FBE4A3C53E61CAEF5981B5290C67B159862ED4368B83379CDE11445EA72C873615F5EC7CD8A17DE2990F83A2FA66BA189063FB21A1E337DA9446B38733E24945C773E16AACE94EDF0C346088B143D2E31CAD17C7959EBFE551557DB7E6A13F73073E8F3EF4550256CA6084F2696DEE9A30A76FC454582E07C7AE444FAF8225331444FB0E0BA051697FB2C4D74924A94D16D2283F31902CA99FCE1B5E29184994E2A99168DAFD2B5D26BC69B465E7C8222552525CDB280266C4E6816A9A74DC22F77014669133D135B19D01FA6EA5CC84D3CA8BF251654CEBAA7E0209ABF1E8ACD365A8C25856CEE924CDA1776CF4CDBB292838BF9AE16A87A8EA8A7C276AA63B4BCE70E6FD290268A45C8445FA98345F9B3A4BEF46B7C89EB5EEA166D12BE537986DF93FEFDF5B51BEF94DC9B43233BDD9D09798FD30161AC5F5C8CA1292AA59DFA1E828534E8C6E1647929F3D298FC797AB60F927AD7AD755F4AE7C84BC72FDC704B3BD0C6F2BEB6CB17371BE29371FD743346757D12359ED3C55E93CD13CB7B29A30B27529EBEAA956D23D45EB0F7053B44DA229E4257DD8294805C24D42368AA651958E6127AAD4043747F55D045E5CE0464A2539C3B91E2A9A4905608A3A82AC50D1B9D2BC82117815829A0B9C82DF973281023DC415A5512D9ADD20742AEE80CB6682DE1A8500259938B6C8AB238E8A1CA21188501791D2208238C7C74E6C6724011732EC5701D19EF3E3EEF2510B1CDA725AE23F086B20F527C180850BEDB94CD94A223D77A8E50D5099707F17A7105ADDE283B6A23AF6D2062B2FC87B7D6C92FEB8CB34A81EC8A74FE2D313F60D82A87C46830F6F59B069412C31CC187AD4B9A9E973153F25F5218EC1A8EEC23E0D8308F879226F8A8227E021DC9C67F4167F56F55710EE8AADF008FDABF86687B63B84970CA3C790FA1BB1F93150357F512291C6797953BC79CC8658024633C89FE6DDC4BFEC82D06FF0BE143C529280C8CF97D5F3D09C97287F26BA796B207DE1CA6FC80055E46B8EC5F710AB0C0C2CBB89D7E005DAE0F63583D77003BCB7DB2A0B560EA49B1134D9971701D8A420CA2A18ED78FC2B96613F7AFDE97F4AE799B7B7910000, N'6.1.3-40302')
SET IDENTITY_INSERT [dbo].[AccountTypes] ON 

INSERT [dbo].[AccountTypes] ([AccountTypeID], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[AccountTypes] ([AccountTypeID], [Name]) VALUES (2, N'ads')
SET IDENTITY_INSERT [dbo].[AccountTypes] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [AcoountTypeID], [Phone], [Email], [Password]) VALUES (1, N'Ayça', N'Calayır', 1, N'342432', N'asd', N'123')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [AcoountTypeID], [Phone], [Email], [Password]) VALUES (2, N'burak', N'kaya', 2, N'43535', N'sad', N'123')
SET IDENTITY_INSERT [dbo].[Employees] OFF
/****** Object:  Index [IX_ProjectID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_ProjectID] ON [dbo].[CustomerRequests]
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employee_EmployeeID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_Employee_EmployeeID] ON [dbo].[EmployeeProjects]
(
	[Employee_EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Project_ProjectID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_Project_ProjectID] ON [dbo].[EmployeeProjects]
(
	[Project_ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AcoountTypeID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_AcoountTypeID] ON [dbo].[Employees]
(
	[AcoountTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerID] ON [dbo].[Projects]
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeeID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_EmployeeID] ON [dbo].[Projects]
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeeID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_EmployeeID] ON [dbo].[Taskks]
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ManagerID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_ManagerID] ON [dbo].[Taskks]
(
	[ManagerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProjectID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_ProjectID] ON [dbo].[Taskks]
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SituaitionID]    Script Date: 5.09.2018 21:08:58 ******/
CREATE NONCLUSTERED INDEX [IX_SituaitionID] ON [dbo].[Taskks]
(
	[SituaitionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerRequests]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CustomerRequests_dbo.Projects_ProjectID] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Projects] ([ProjectID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerRequests] CHECK CONSTRAINT [FK_dbo.CustomerRequests_dbo.Projects_ProjectID]
GO
ALTER TABLE [dbo].[EmployeeProjects]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EmployeeProjects_dbo.Employees_Employee_EmployeeID] FOREIGN KEY([Employee_EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeProjects] CHECK CONSTRAINT [FK_dbo.EmployeeProjects_dbo.Employees_Employee_EmployeeID]
GO
ALTER TABLE [dbo].[EmployeeProjects]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EmployeeProjects_dbo.Projects_Project_ProjectID] FOREIGN KEY([Project_ProjectID])
REFERENCES [dbo].[Projects] ([ProjectID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeProjects] CHECK CONSTRAINT [FK_dbo.EmployeeProjects_dbo.Projects_Project_ProjectID]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Employees_dbo.AccountTypes_AcoountTypeID] FOREIGN KEY([AcoountTypeID])
REFERENCES [dbo].[AccountTypes] ([AccountTypeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_dbo.Employees_dbo.AccountTypes_AcoountTypeID]
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
ALTER TABLE [dbo].[Taskks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Taskks_dbo.Employees_EmployeeID] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Taskks] CHECK CONSTRAINT [FK_dbo.Taskks_dbo.Employees_EmployeeID]
GO
ALTER TABLE [dbo].[Taskks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Taskks_dbo.Employees_ManagerID] FOREIGN KEY([ManagerID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Taskks] CHECK CONSTRAINT [FK_dbo.Taskks_dbo.Employees_ManagerID]
GO
ALTER TABLE [dbo].[Taskks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Taskks_dbo.Projects_ProjectID] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Projects] ([ProjectID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Taskks] CHECK CONSTRAINT [FK_dbo.Taskks_dbo.Projects_ProjectID]
GO
ALTER TABLE [dbo].[Taskks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Taskks_dbo.Situaitions_SituaitionID] FOREIGN KEY([SituaitionID])
REFERENCES [dbo].[Situaitions] ([SituationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Taskks] CHECK CONSTRAINT [FK_dbo.Taskks_dbo.Situaitions_SituaitionID]
GO
USE [master]
GO
ALTER DATABASE [TaskManagemenetContext] SET  READ_WRITE 
GO
