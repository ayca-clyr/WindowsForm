USE [master]
GO
/****** Object:  Database [alfa_v2_adonet_white_db]    Script Date: 15.10.2016 17:20:35 ******/
CREATE DATABASE [alfa_v2_adonet_white_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'alfa_v2_adonet_white_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2012\MSSQL\DATA\alfa_v2_adonet_white_db.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'alfa_v2_adonet_white_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2012\MSSQL\DATA\alfa_v2_adonet_white_db_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [alfa_v2_adonet_white_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET RECOVERY FULL 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET  MULTI_USER 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [alfa_v2_adonet_white_db]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorID] [int] NOT NULL,
	[PoorlyID] [int] NOT NULL,
	[DateOfAppointment] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Appointment_Information_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[City]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[City](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clinic]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clinic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ExaminationPeriod] [smallint] NOT NULL,
 CONSTRAINT [PK_Clinic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[County]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[County](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CityID] [int] NOT NULL,
 CONSTRAINT [PK_Town_Information] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[HospitalClinicExaminationPlaceID] [int] NOT NULL,
 CONSTRAINT [PK_Doctor_Information] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Examination_Place]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Examination_Place](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Examination_Place] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital_Clinic_Examination_Place]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital_Clinic_Examination_Place](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClinicID] [int] NOT NULL,
	[HospitalID] [int] NOT NULL,
	[Examination_PlaceID] [int] NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
 CONSTRAINT [PK_Hospital_Clinic_Examination_Place] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital_Information]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hospital_Information](
	[HospitalID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[CityID] [int] NOT NULL,
	[CountyID] [int] NOT NULL,
 CONSTRAINT [PK_Hospital] PRIMARY KEY CLUSTERED 
(
	[HospitalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Poorly_Contact_Information]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Poorly_Contact_Information](
	[PoorlyID] [int] NOT NULL,
	[MobilePhone] [varchar](14) NULL,
	[LandPhone] [varchar](14) NULL,
	[Mail] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Contact_Information] PRIMARY KEY CLUSTERED 
(
	[PoorlyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Poorly_Personel_Information]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Poorly_Personel_Information](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[TCNumber] [varchar](11) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[GenderID] [int] NOT NULL,
	[FatherName] [varchar](50) NULL,
	[MotherName] [varchar](50) NULL,
	[BirthPlace] [varchar](50) NULL,
 CONSTRAINT [PK_Personel_Information] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Poorly_Safety_Information]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Poorly_Safety_Information](
	[PoorlyID] [int] NOT NULL,
	[Password] [varchar](36) NOT NULL,
	[SecurityQuestionID] [int] NOT NULL,
	[Answer] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Safety_Information] PRIMARY KEY CLUSTERED 
(
	[PoorlyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Security_Question]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Security_Question](
	[ID] [int] NOT NULL,
	[Question] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Security_Question] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vw_CityCountyClinicGetDoctor]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_CityCountyClinicGetDoctor]
as
select distinct ci.ID as CityId, co.ID as CountyId, cl.ID as ClinicId, d.ID,d.FirstName,d.LastName from City ci
	join County co on co.CityID = ci.ID
	join Hospital_Information hi on co.ID=hi.CountyID
	join Hospital_Clinic_Examination_Place hc on hc.HospitalID = hi.HospitalID
	join Clinic cl on cl.ID= hc.ClinicID
	join Examination_Place ex on ex.ID = hc.Examination_PlaceID
	join Doctor d on d.HospitalClinicExaminationPlaceID = hc.ID
GO
/****** Object:  View [dbo].[vw_CityCountyClinicGetExamination]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_CityCountyClinicGetExamination]
as
select distinct ci.ID as CityId, co.ID CountyId, cl.ID as ClinicId, ex.ID, ex.Name from City ci
	join County co on co.CityID = ci.ID
	join Hospital_Information hi on co.ID=hi.CountyID
	join Hospital_Clinic_Examination_Place hc on hc.HospitalID = hi.HospitalID
	join Clinic cl on cl.ID= hc.ClinicID
	join Examination_Place ex on ex.ID = hc.Examination_PlaceID
GO
/****** Object:  View [dbo].[vw_CityCountyClinicGetHospital]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_CityCountyClinicGetHospital]
AS
SELECT DISTINCT hi.HospitalID, hi.Name, hi.CityID, hi.CountyID, cl.ID
FROM            dbo.City AS ci INNER JOIN
                         dbo.County AS co ON co.CityID = ci.ID INNER JOIN
                         dbo.Hospital_Information AS hi ON co.ID = hi.CountyID INNER JOIN
                         dbo.Hospital_Clinic_Examination_Place AS hc ON hc.HospitalID = hi.HospitalID INNER JOIN
                         dbo.Clinic AS cl ON cl.ID = hc.ClinicID

GO
/****** Object:  View [dbo].[vw_CityCountyClinicHospitalGetDoctors]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_CityCountyClinicHospitalGetDoctors]
AS
SELECT        doc.ID, doc.FirstName, doc.LastName, hi.HospitalID, cl.ID AS ClinicID, ep.ID AS examinationPlaceID, cl.Name, hcep.StartTime, hcep.EndTime
FROM            dbo.Doctor AS doc FULL OUTER JOIN
                         dbo.Hospital_Clinic_Examination_Place AS hcep ON doc.HospitalClinicExaminationPlaceID = hcep.ID FULL OUTER JOIN
                         dbo.Examination_Place AS ep ON hcep.Examination_PlaceID = ep.ID FULL OUTER JOIN
                         dbo.Clinic AS cl ON hcep.ClinicID = cl.ID FULL OUTER JOIN
                         dbo.Hospital_Information AS hi ON hcep.HospitalID = hi.HospitalID FULL OUTER JOIN
                         dbo.County AS co ON hi.CountyID = co.ID FULL OUTER JOIN
                         dbo.City AS ci ON co.CityID = ci.ID

GO
/****** Object:  View [dbo].[vw_CityCountyClinicHospitalGetExamination]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_CityCountyClinicHospitalGetExamination]
as
select distinct ci.ID as CityId, co.ID as CountyId, cl.ID as ClinicId ,hc.HospitalID as HospitalId, ex.ID, ex.Name from City ci
	join County co on co.CityID = ci.ID
	join Hospital_Information hi on co.ID=hi.CountyID
	join Hospital_Clinic_Examination_Place hc on hc.HospitalID = hi.HospitalID
	join Clinic cl on cl.ID= hc.ClinicID
	join Examination_Place ex on ex.ID = hc.Examination_PlaceID
GO
/****** Object:  View [dbo].[vw_CityCountyClinicHospitalGetExaminationPlace]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_CityCountyClinicHospitalGetExaminationPlace]
AS
SELECT        hi.HospitalID, ep.Name, ep.ID, cl.ID AS ClinicID
FROM            dbo.Examination_Place AS ep INNER JOIN
                         dbo.Hospital_Clinic_Examination_Place AS hcep ON ep.ID = hcep.Examination_PlaceID INNER JOIN
                         dbo.Clinic AS cl ON hcep.ClinicID = cl.ID INNER JOIN
                         dbo.Hospital_Information AS hi ON hcep.HospitalID = hi.HospitalID INNER JOIN
                         dbo.County AS co ON hi.CountyID = co.ID INNER JOIN
                         dbo.City AS c ON co.CityID = c.ID

GO
/****** Object:  View [dbo].[vw_CityCountyGetHospital]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_CityCountyGetHospital]
as
select distinct ci.ID as CityId, co.ID as CountyId, hi.HospitalID, hi.Name from City ci
	join County co on co.CityID = ci.ID
	join Hospital_Information hi on co.ID=hi.CountyID

GO
/****** Object:  View [dbo].[vw_CityCountyHospitalGetClinic]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_CityCountyHospitalGetClinic]
as
select ci.ID CityId, co.ID CountyId, hi.HospitalID as HospitalId, cl.ID, cl.Name  from City ci
	join County co on co.CityID = ci.ID
	join Hospital_Information hi on co.ID=hi.CountyID
	join Hospital_Clinic_Examination_Place hc on hc.HospitalID = hi.HospitalID
	join Clinic cl on cl.ID= hc.ClinicID

GO
/****** Object:  View [dbo].[vw_DoctorList]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_DoctorList]
AS
SELECT        dr.ID, dr.FirstName, dr.LastName, clnc.Name AS ClinicName, hospital.Name AS HospitalName, ep.Name AS exName, clnc.ID AS ClinicID, hospital.HospitalID, clnc.ExaminationPeriod AS Period, hcep.StartTime, 
                         hcep.EndTime
FROM            dbo.Doctor AS dr INNER JOIN
                         dbo.Hospital_Clinic_Examination_Place AS hcep ON dr.HospitalClinicExaminationPlaceID = hcep.ID INNER JOIN
                         dbo.Clinic AS clnc ON hcep.ClinicID = clnc.ID INNER JOIN
                         dbo.Hospital_Information AS hospital ON hcep.HospitalID = hospital.HospitalID INNER JOIN
                         dbo.Examination_Place AS ep ON hcep.Examination_PlaceID = ep.ID

GO
/****** Object:  View [dbo].[Vw_GetCity]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[Vw_GetCity]
as
select City.ID,City.Name from City

GO
/****** Object:  View [dbo].[vw_GetClinic]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vw_GetClinic]
as
select distinct c.ID, c.Name,hi.CountyID from City ci
	join Hospital_Information hi on ci.ID=hi.CityID
	join Hospital_Clinic_Examination_Place hc on hc.HospitalID = hi.HospitalID
	join Clinic c on c.ID= hc.ClinicID
GO
/****** Object:  View [dbo].[Vw_Getcounty]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_Getcounty]
AS
SELECT        ID, Name, CityID
FROM            dbo.County AS co

GO
/****** Object:  View [dbo].[vw_GetDoctor]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[vw_GetDoctor]
as
select ID,FirstName,LastName from Doctor
GO
/****** Object:  View [dbo].[vw_GetExaminationPlace]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[vw_GetExaminationPlace]
as
Select ID,Name from Examination_Place
GO
/****** Object:  View [dbo].[Vw_GetGender]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_GetGender]
AS
SELECT        ID AS GenderId, Name AS GenderName
FROM            dbo.Gender

GO
/****** Object:  View [dbo].[vw_GetHospital]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[vw_GetHospital]
as
select HospitalID,Name from Hospital_Information
GO
/****** Object:  View [dbo].[Vw_GetQuestion]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_GetQuestion]
AS
SELECT        ID AS QuestionId, Question AS QuestionName
FROM            dbo.Security_Question

GO
/****** Object:  View [dbo].[vw_Login]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_Login]
as
SELECT ppl.ID,ppl.TCNumber,psi.Password FROM Poorly_Personel_Information ppl JOIN Poorly_Safety_Information psi on ppl.ID = psi.PoorlyID


GO
/****** Object:  View [dbo].[vw_Poorly]    Script Date: 15.10.2016 17:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Poorly]
AS
SELECT        ppi.ID, ppi.FirstName, ppi.LastName, ppi.TCNumber, ppi.BirthDate, ppi.GenderID, ppi.FatherName, ppi.MotherName, ppi.BirthPlace, g.Name, pci.MobilePhone, pci.Mail, pci.LandPhone, psi.Password
FROM            dbo.Poorly_Contact_Information AS pci INNER JOIN
                         dbo.Poorly_Personel_Information AS ppi ON pci.PoorlyID = ppi.ID INNER JOIN
                         dbo.Poorly_Safety_Information AS psi ON ppi.ID = psi.PoorlyID INNER JOIN
                         dbo.Gender AS g ON ppi.GenderID = g.ID

GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([ID], [Name]) VALUES (1, N'İSTANBUL')
INSERT [dbo].[City] ([ID], [Name]) VALUES (2, N'ANKARA')
INSERT [dbo].[City] ([ID], [Name]) VALUES (3, N'İZMİR')
INSERT [dbo].[City] ([ID], [Name]) VALUES (4, N'BURSA')
INSERT [dbo].[City] ([ID], [Name]) VALUES (5, N'KONYA')
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Clinic] ON 

INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (1, N'ACİL TIP', 10)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (2, N'BEYİN VE SİNİR CERRAHİSİ', 15)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (4, N'ÇOCUK CERRAHİSİ', 10)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (5, N'GÖĞÜS CERRAHİSİ', 15)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (7, N'GÖĞÜS HASTALIKLARI', 10)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (8, N'KULAK BURUN BOĞAZ HASTALIKLARI', 10)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (9, N'NÖROLOJİ', 10)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (10, N'GÖZ HASTALIKLARI', 10)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (11, N'KARDİYOLOJİ', 15)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (12, N'GENEL CERRAHİ', 15)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (13, N'DİŞ HEKİMLİĞİ', 10)
INSERT [dbo].[Clinic] ([ID], [Name], [ExaminationPeriod]) VALUES (14, N'KALP VE DAMAR CERRAHİSİ', 15)
SET IDENTITY_INSERT [dbo].[Clinic] OFF
SET IDENTITY_INSERT [dbo].[County] ON 

INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (1, N'BAĞCILAR', 1)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (2, N'BAHÇELİEVLER', 1)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (3, N'BAKIRKÖY', 1)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (4, N'BEŞİKTAŞ', 1)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (5, N'BEYKOZ', 1)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (6, N'ESENLER', 1)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (7, N'ESENYURT', 1)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (8, N'SİLİVRİ', 1)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (9, N'ALTINDAĞ', 2)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (10, N'BEYPAZARI', 2)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (11, N'ÇANKAYA', 2)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (12, N'ÇUBUK', 2)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (13, N'ELMADAĞ', 2)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (14, N'ETİMESGUT', 2)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (15, N'KEÇİÖREN', 2)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (16, N'MAMAK', 2)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (17, N'ALİAĞA', 3)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (18, N'BERGAMA', 3)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (19, N'BORNAVA', 3)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (20, N'BUCA', 3)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (21, N'ÇEŞME', 3)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (22, N'GEMLİK', 4)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (23, N'İNEGÖL', 4)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (24, N'İZNİK', 4)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (25, N'NİLÜFER', 4)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (26, N'ORHANELİ', 4)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (27, N'ORHANGAZİ', 4)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (28, N'OSMANGAZİ', 4)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (29, N'AKŞEHİR', 5)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (30, N'BEYŞEHİR', 5)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (31, N'CİHANBEYLİ', 5)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (32, N'EREYLİ', 5)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (33, N'ILGIN', 5)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (34, N'MERAM', 5)
INSERT [dbo].[County] ([ID], [Name], [CityID]) VALUES (35, N'SELÇIKLU', 5)
SET IDENTITY_INSERT [dbo].[County] OFF
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (1, N'Hakan', N'Gündoğan', 2)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (2, N'Ebru', N'Zülfikaroğlu', 3)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (3, N'Mustafa', N'Alihanoğlu', 4)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (4, N'Müjde', N'Koyuncu', 7)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (5, N'Sevim', N'Turhan', 9)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (6, N'Ali', N'Özdek', 10)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (7, N'Pınar', N'Tokatlıoğlu', 11)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (8, N'Mehmet', N'Kantar', 13)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (9, N'Hira Selma', N'Kalkan', 14)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (10, N'Muhittin', N'Eski', 15)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (11, N'Adnan', N'Sayar', 16)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (12, N'Tamer', N'Seyhan', 17)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [HospitalClinicExaminationPlaceID]) VALUES (13, N'Serdar', N'Alpaslan', 18)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
SET IDENTITY_INSERT [dbo].[Examination_Place] ON 

INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (1, N'Beyin cerrahisi BEH 1')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (2, N'Beyin Cerrahisi BEH 2')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (3, N'Beyin Cerrahisi BEH 3')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (4, N'BEH Çocuk Cerrrahisi 2')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (5, N'BEH Çocuk Cerrahisi 3')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (6, N'BEH Çocuk Cerrahisi 4')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (7, N'BEH Çocuk Cerrahisi 5')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (8, N'Göğüs Cerrahisi BEH 1')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (9, N'Göğüs Cerrahisi BEH 2')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (10, N'Göz Hastalıkları BEH 1')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (11, N'Göz Hastalıkları BEH 2')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (12, N'Göz Hastalıkları BEH 3')
INSERT [dbo].[Examination_Place] ([ID], [Name]) VALUES (13, N'Göz Hastalıkları BEH 4')
SET IDENTITY_INSERT [dbo].[Examination_Place] OFF
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([ID], [Name]) VALUES (1, N'Erkek')
INSERT [dbo].[Gender] ([ID], [Name]) VALUES (2, N'Kadın')
SET IDENTITY_INSERT [dbo].[Gender] OFF
SET IDENTITY_INSERT [dbo].[Hospital_Clinic_Examination_Place] ON 

INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (2, 2, 1, 1, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (3, 2, 1, 2, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (4, 2, 1, 3, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (7, 4, 1, 4, CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (9, 4, 1, 5, CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (10, 4, 1, 6, CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (11, 4, 1, 7, CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (13, 5, 1, 8, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (14, 5, 1, 9, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (15, 10, 1, 10, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (16, 10, 1, 11, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (17, 10, 1, 12, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Hospital_Clinic_Examination_Place] ([ID], [ClinicID], [HospitalID], [Examination_PlaceID], [StartTime], [EndTime]) VALUES (18, 10, 1, 13, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[Hospital_Clinic_Examination_Place] OFF
SET IDENTITY_INSERT [dbo].[Hospital_Information] ON 

INSERT [dbo].[Hospital_Information] ([HospitalID], [Name], [CityID], [CountyID]) VALUES (1, N'BAĞCILAR EĞİTİM VE ARAŞTIRMA HASTAHANESİ', 1, 1)
INSERT [dbo].[Hospital_Information] ([HospitalID], [Name], [CityID], [CountyID]) VALUES (2, N'BAHÇELİEVLER DEVLET HASTAHANESİ', 1, 2)
SET IDENTITY_INSERT [dbo].[Hospital_Information] OFF
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (5, N'(505)-255-1525', NULL, N'hakkibulut@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (8, N'(555)-125-5465', NULL, N'hakantasiyan@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (9, N'(541)-569-4578', NULL, N'sedefbeyaz@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (10, N'(542)-625-7898', NULL, N'halilyurtsever@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (11, N'(545)-755-7425', NULL, N'islalkus@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (12, N'(532)-356-7512', NULL, N'ferhandert@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (13, N'(541)-741-4565', NULL, N'hiyazigul@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (14, N'(546)-758-7898', NULL, N'deryayurt@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (15, N'(535)-152-8855', NULL, N'sedaayik@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (16, N'(556)-456-7898', NULL, N'sametyesildal@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (17, N'(557)-454-6545', NULL, N'ihsansungur@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (18, N'(534)-124-1232', NULL, N'yurdagulcay@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (19, N'(532)-741-1414', NULL, N'nerimancamci@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (20, N'(555)-747-8797', NULL, N'songulhakbilen@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (21, N'(556)-951-2535', NULL, N'ismailyilmaz@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (22, N'(542)-541-3552', NULL, N'nazimbircan@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (23, N'(505)-656-5447', NULL, N'hasanyilmaz@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (24, N'(533)-965-6535', NULL, N'demirci.ferat@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (25, N'(111) 111-1111', N'(111) 111-1111', N'asdasdas@hotmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (26, N'(533) 965-6535', N'(   )    -    ', N'demirci.ferat2@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (27, N'(533) 965-6535', N'(   )    -    ', N'demirci.ferat2@gmail.com')
INSERT [dbo].[Poorly_Contact_Information] ([PoorlyID], [MobilePhone], [LandPhone], [Mail]) VALUES (28, N'(555) 555-5555', N'(   )    -    ', N'burakilsonn@gmail.com')
SET IDENTITY_INSERT [dbo].[Poorly_Personel_Information] ON 

INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (5, N'Hakkı', N'Bulut', N'12457898652', CAST(N'1975-04-05' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (8, N'Hakan', N'Taşıyan', N'45123265784', CAST(N'1976-06-11' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (9, N'Sedef', N'Beyaz', N'54659878451', CAST(N'1985-01-25' AS Date), 2, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (10, N'Halil', N'Yurtsever', N'65784512325', CAST(N'1990-03-12' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (11, N'İclal', N'Kuş', N'68512057963', CAST(N'1991-04-23' AS Date), 2, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (12, N'Ferhan', N'Dert', N'85296374114', CAST(N'1970-10-09' AS Date), 2, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (13, N'Niyazi', N'Gül', N'25639874120', CAST(N'1964-05-21' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (14, N'Derya', N'Yurt', N'87965236452', CAST(N'1985-07-19' AS Date), 2, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (15, N'Seda', N'Ayık', N'65237401092', CAST(N'1988-09-28' AS Date), 2, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (16, N'Samet', N'Yeşildal', N'56458795263', CAST(N'1994-03-22' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (17, N'İhsan', N'Sungur', N'25789823150', CAST(N'1994-11-17' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (18, N'Yurdagül', N'Çay', N'78521630124', CAST(N'1987-05-22' AS Date), 2, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (19, N'Neriman', N'Çamcı', N'85412369501', CAST(N'1976-06-14' AS Date), 2, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (20, N'Songül', N'Hakbilen', N'45632178541', CAST(N'1992-01-12' AS Date), 2, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (21, N'İsmail', N'Yılmaz', N'24986523120', CAST(N'1985-10-25' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (22, N'Nazım', N'Bircan', N'51201475236', CAST(N'1994-07-26' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (23, N'Hasan', N'Yılmaz', N'51623785236', CAST(N'1974-12-24' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (24, N'Ferhat', N'Demirci', N'27463075048', CAST(N'1993-04-10' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (25, N'asdsad', N'sadsad', N'12345678900', CAST(N'1994-10-09' AS Date), 1, N'asd', N'sadsad', N'sadsad')
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (26, N'Ferhat', N'Demirci', N'27463075049', CAST(N'1993-04-10' AS Date), 1, N'Rafet', N'Demirci', N'Amasya')
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (27, N'Ferhat', N'Demirci', N'27463075050', CAST(N'1993-04-10' AS Date), 1, N'', N'Demirci', N'')
INSERT [dbo].[Poorly_Personel_Information] ([ID], [FirstName], [LastName], [TCNumber], [BirthDate], [GenderID], [FatherName], [MotherName], [BirthPlace]) VALUES (28, N'Burak', N'Kaya', N'12457896325', CAST(N'1991-06-14' AS Date), 1, N'', N'Kaya', N'')
SET IDENTITY_INSERT [dbo].[Poorly_Personel_Information] OFF
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (5, N'Hb124578', 1, N'AHMET')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (8, N'Hk875421', 2, N'Mehmet')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (10, N'Hy123654', 2, N'Merve')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (11, N'İa214578', 3, N'Karnıbahar')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (12, N'Fd857496', 4, N'Onur')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (13, N'Ng454545', 4, N'Selman')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (14, N'Dy121212', 5, N'Kuş')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (15, N'Sa456565', 5, N'Güvercin')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (16, N'Sy989898', 2, N'Davut')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (17, N'İs787878', 2, N'Gamze')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (18, N'Yç857412', 1, N'Furkan')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (19, N'Nç951531', 3, N'Fasülye')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (20, N'Sh441122', 3, N'Nohut')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (21, N'İy774411', 2, N'Ufuk')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (22, N'Nb157895', 3, N'Pilav')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (23, N'Hy653212', 4, N'Feride')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (24, N'Fd274630', 2, N'Samet')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (25, N'123456', 2, N'sadasd')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (26, N'123456789Fd', 5, N'YOK')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (27, N'123456789fd', 1, N'bilemem')
INSERT [dbo].[Poorly_Safety_Information] ([PoorlyID], [Password], [SecurityQuestionID], [Answer]) VALUES (28, N'123456bk', 1, N'Bilmiyorum')
INSERT [dbo].[Security_Question] ([ID], [Question]) VALUES (1, N'En sevdiğiniz çocukluk arkadaşınız')
INSERT [dbo].[Security_Question] ([ID], [Question]) VALUES (2, N'İlk okul öğretmeninizin adı')
INSERT [dbo].[Security_Question] ([ID], [Question]) VALUES (3, N'En sevdiğiniz yemek')
INSERT [dbo].[Security_Question] ([ID], [Question]) VALUES (4, N'Annenizin kızlık soyadı')
INSERT [dbo].[Security_Question] ([ID], [Question]) VALUES (5, N'İlk evcil hayvanın')
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Information_Doctor_Information] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctor] ([ID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Information_Doctor_Information]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Information_Poorly_Personel_Information] FOREIGN KEY([PoorlyID])
REFERENCES [dbo].[Poorly_Personel_Information] ([ID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Information_Poorly_Personel_Information]
GO
ALTER TABLE [dbo].[County]  WITH CHECK ADD  CONSTRAINT [FK_County_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([ID])
GO
ALTER TABLE [dbo].[County] CHECK CONSTRAINT [FK_County_City]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Information_Hospital_Clinic_Examination_Place] FOREIGN KEY([HospitalClinicExaminationPlaceID])
REFERENCES [dbo].[Hospital_Clinic_Examination_Place] ([ID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Information_Hospital_Clinic_Examination_Place]
GO
ALTER TABLE [dbo].[Hospital_Clinic_Examination_Place]  WITH CHECK ADD  CONSTRAINT [FK_Hospital_Clinic_Examination_Place_Clinic_Information] FOREIGN KEY([ClinicID])
REFERENCES [dbo].[Clinic] ([ID])
GO
ALTER TABLE [dbo].[Hospital_Clinic_Examination_Place] CHECK CONSTRAINT [FK_Hospital_Clinic_Examination_Place_Clinic_Information]
GO
ALTER TABLE [dbo].[Hospital_Clinic_Examination_Place]  WITH CHECK ADD  CONSTRAINT [FK_Hospital_Clinic_Examination_Place_Examination_Place] FOREIGN KEY([Examination_PlaceID])
REFERENCES [dbo].[Examination_Place] ([ID])
GO
ALTER TABLE [dbo].[Hospital_Clinic_Examination_Place] CHECK CONSTRAINT [FK_Hospital_Clinic_Examination_Place_Examination_Place]
GO
ALTER TABLE [dbo].[Hospital_Clinic_Examination_Place]  WITH CHECK ADD  CONSTRAINT [FK_Hospital_Clinic_Examination_Place_Hospital_Information] FOREIGN KEY([HospitalID])
REFERENCES [dbo].[Hospital_Information] ([HospitalID])
GO
ALTER TABLE [dbo].[Hospital_Clinic_Examination_Place] CHECK CONSTRAINT [FK_Hospital_Clinic_Examination_Place_Hospital_Information]
GO
ALTER TABLE [dbo].[Hospital_Information]  WITH CHECK ADD  CONSTRAINT [FK_Hospital_Information_Country_Information] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([ID])
GO
ALTER TABLE [dbo].[Hospital_Information] CHECK CONSTRAINT [FK_Hospital_Information_Country_Information]
GO
ALTER TABLE [dbo].[Hospital_Information]  WITH CHECK ADD  CONSTRAINT [FK_Hospital_Information_Town_Information] FOREIGN KEY([CountyID])
REFERENCES [dbo].[County] ([ID])
GO
ALTER TABLE [dbo].[Hospital_Information] CHECK CONSTRAINT [FK_Hospital_Information_Town_Information]
GO
ALTER TABLE [dbo].[Poorly_Personel_Information]  WITH CHECK ADD  CONSTRAINT [FK_Poorly_Personel_Information_Gender1] FOREIGN KEY([GenderID])
REFERENCES [dbo].[Gender] ([ID])
GO
ALTER TABLE [dbo].[Poorly_Personel_Information] CHECK CONSTRAINT [FK_Poorly_Personel_Information_Gender1]
GO
ALTER TABLE [dbo].[Poorly_Safety_Information]  WITH CHECK ADD  CONSTRAINT [FK_Poorly_Safety_Information_Security_Question] FOREIGN KEY([SecurityQuestionID])
REFERENCES [dbo].[Security_Question] ([ID])
GO
ALTER TABLE [dbo].[Poorly_Safety_Information] CHECK CONSTRAINT [FK_Poorly_Safety_Information_Security_Question]
GO
ALTER TABLE [dbo].[Poorly_Personel_Information]  WITH CHECK ADD  CONSTRAINT [TC_Number] CHECK  ((len([TCNumber])=(11)))
GO
ALTER TABLE [dbo].[Poorly_Personel_Information] CHECK CONSTRAINT [TC_Number]
GO
/****** Object:  StoredProcedure [dbo].[sp_DoctorList]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DoctorList]
(
@hospitalID  int,
@clinicID  int
)
as
select * from vw_DoctorList where ClinicID=@clinicID and HospitalID=@hospitalID
GO
/****** Object:  StoredProcedure [dbo].[sp_examinationPlaceGetAllDoctor]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_examinationPlaceGetAllDoctor]
(
@examinationPlaceID int
)
as
select ID,FirstName,LastName from vw_CityCountyClinicHospitalGetDoctors where examinationPlaceID=@examinationPlaceID
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCity]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllCity]
as

select * from Vw_GetCity

GO
/****** Object:  StoredProcedure [dbo].[Sp_GetALLClinic]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_GetALLClinic]
(
@CountyId int
)
as
Select ID,Name from vw_GetClinic Where CountyID=@CountyId
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetALLCounty]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_GetALLCounty]
(
@cityID int
)
as
select ID,Name  from Vw_Getcounty where CityID=@cityID
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDoctor]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[sp_GetAllDoctor]
 (
 @examinationID int
 )
 as
BEGIN
	select * from vw_CityCountyClinicHospitalGetDoctors where ExamID=@examinationID
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetALLHospital]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_GetALLHospital]
(
@countyID int,
@cityID int,
@clinicID int
)
as
Select HospitalID,Name from vw_CityCountyClinicGetHospital Where CountyID=@countyID and CityID=@cityID and ID=@clinicID
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllPorly]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetAllPorly]

as

Select * from vw_Poorly 

GO
/****** Object:  StoredProcedure [dbo].[sp_GetCity]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetCity]
(
@id int
)
as
select * from Vw_GetCity where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[Sp_GetCounty]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_GetCounty]
(
@id int
)
as
select ilce_ID from Vw_Getcounty where ilce_ID=@id


GO
/****** Object:  StoredProcedure [dbo].[sp_GetDoctor]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_GetDoctor]
(
@id int
)
as
select * from vw_GetDoctor where ID=@id
GO
/****** Object:  StoredProcedure [dbo].[sp_GetExaminationPlace]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetExaminationPlace]
(
@hospitalId int,
@clinicId int
)
as
select ID,Name from vw_CityCountyClinicHospitalGetExaminationPlace where HospitalID=@hospitalId and ClinicID=@clinicId
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetGender]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_GetGender]

as
select GenderId,GenderName from Vw_GetGender
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHospital]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_GetHospital]
(
@id int
)
as
select * from Vw_GetHospital where HospitalID=@id
GO
/****** Object:  StoredProcedure [dbo].[sp_GetPoorly]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetPoorly]
(
 @id int
)
AS
SELECT * FROM vw_Poorly WHERE ID=@id


GO
/****** Object:  StoredProcedure [dbo].[sp_GetQuestion]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetQuestion]
as
select QuestionId , QuestionName from Vw_GetQuestion
GO
/****** Object:  StoredProcedure [dbo].[sp_hospitalclinicGetAllDoctor]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_hospitalclinicGetAllDoctor]
(
@hospitalId int,
@clinicId int
)
as
select ID,FirstName,LastName from vw_CityCountyClinicHospitalGetDoctors where HospitalID=@hospitalId and ClinicID=@clinicId
GO
/****** Object:  StoredProcedure [dbo].[sp_LoginPoorly]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_LoginPoorly](
@TCNumber varchar(11),
@password varchar(36)
)
as
SELECT ID FROM vw_Login WHERE TCNumber=@TCNumber and Password=@password


GO
/****** Object:  StoredProcedure [dbo].[sp_MailControl]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_MailControl]
(
@tcnumber varchar(11),
@mail varchar(100)
)
as
select ID, FirstName,LastName,TCNumber,Mail,Password From vw_Poorly Where  Mail=@mail and TCNumber=@tcnumber
GO
/****** Object:  StoredProcedure [dbo].[Sp_PoorlySave]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_PoorlySave]
(
@firstName varchar(50),
@lastName varchar(50),
@tcNumber char(11),
@birthDate date,
@genderId int,
@fatherName varchar(50),
@motherName varchar(50),
@birthPlace varchar(50),
@mobilePhone char(20),
@landPhone char(20),
@mail varchar(100),
@password varchar(36),
@securityQuestionId int,
@answer nvarchar(100)
)
AS
BEGIN
IF  DATEDIFF(YEAR,@birthDate ,SYSDATETIME()) > 15
BEGIN
declare @poorlyId int
	
	insert into Poorly_Personel_Information(
	FirstName,LastName,TCNumber,BirthDate,FatherName,
	MotherName,BirthPlace,GenderID)
	values (@firstName,@lastName,@tcNumber,@birthDate,
	@fatherName,@lastName,@birthPlace,@genderId)

	SET @poorlyId =(Select ID from Poorly_Personel_Information where ID=(SELECT SCOPE_IDENTITY()))

	insert into Poorly_Contact_Information(PoorlyID, MobilePhone,LandPhone,Mail)
	values (@poorlyId, @mobilePhone,@landPhone,@mail)

	insert into Poorly_Safety_Information(PoorlyID, Password,Answer,SecurityQuestionId) 
	values(@poorlyId, @password,@answer,@securityQuestionId)

 END

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_SelectCountyGetALLHospital]    Script Date: 15.10.2016 17:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_SelectCountyGetALLHospital]
(
@countyID int
)
as
Select Distinct HospitalID,Name from vw_CityCountyClinicGetHospital Where CountyID=@countyID 
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[24] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ci"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "co"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hi"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 252
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hc"
            Begin Extent = 
               Top = 120
               Left = 246
               Bottom = 250
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cl"
            Begin Extent = 
               Top = 269
               Left = 26
               Bottom = 382
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
E' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicGetHospital'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'nd
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicGetHospital'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicGetHospital'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[13] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "doc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 305
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hcep"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "ep"
            Begin Extent = 
               Top = 138
               Left = 274
               Bottom = 234
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cl"
            Begin Extent = 
               Top = 234
               Left = 274
               Bottom = 347
               Right = 462
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hi"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "co"
            Begin Extent = 
               Top = 348
               Left = 246
               Bottom = 461
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ci"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 498
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicHospitalGetDoctors'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'        End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicHospitalGetDoctors'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicHospitalGetDoctors'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ep"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hcep"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cl"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 215
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hi"
            Begin Extent = 
               Top = 138
               Left = 264
               Bottom = 268
               Right = 434
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "co"
            Begin Extent = 
               Top = 216
               Left = 38
               Bottom = 329
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 270
               Left = 246
               Bottom = 366
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 117' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicHospitalGetExaminationPlace'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicHospitalGetExaminationPlace'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CityCountyClinicHospitalGetExaminationPlace'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "dr"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 305
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hcep"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "clnc"
            Begin Extent = 
               Top = 138
               Left = 274
               Bottom = 251
               Right = 462
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hospital"
            Begin Extent = 
               Top = 252
               Left = 274
               Bottom = 382
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ep"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 366
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_DoctorList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_DoctorList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_DoctorList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "co"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 175
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Getcounty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Getcounty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Gender"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_GetGender'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_GetGender'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Security_Question"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_GetQuestion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_GetQuestion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "pci"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ppi"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "psi"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "g"
            Begin Extent = 
               Top = 138
               Left = 266
               Bottom = 234
               Right = 436
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Poorly'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Poorly'
GO
USE [master]
GO
ALTER DATABASE [alfa_v2_adonet_white_db] SET  READ_WRITE 
GO
