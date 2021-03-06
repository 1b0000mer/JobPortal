USE [master]
GO
/****** Object:  Database [Jobs]    Script Date: 12/10/2018 10:59:48 PM ******/
CREATE DATABASE [Jobs]
 
GO
ALTER DATABASE [Jobs] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Jobs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Jobs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Jobs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Jobs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Jobs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Jobs] SET ARITHABORT OFF 
GO
ALTER DATABASE [Jobs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Jobs] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Jobs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Jobs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Jobs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Jobs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Jobs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Jobs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Jobs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Jobs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Jobs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Jobs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Jobs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Jobs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Jobs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Jobs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Jobs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Jobs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Jobs] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Jobs] SET  MULTI_USER 
GO
ALTER DATABASE [Jobs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Jobs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Jobs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Jobs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [Jobs]
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 12/10/2018 10:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Login]
@user varchar(50), @pass varchar(20)
as
begin
	select 	* from Admin ad where ad.AdName=@user and ad.AdPass=@pass 
end


GO
/****** Object:  StoredProcedure [dbo].[sp_Signin]    Script Date: 12/10/2018 10:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Signin]
@user varchar(50), @pass varchar(20), @phone varchar(20),@email varchar(30)
as
begin
	INSERT INTO Admin(AdPass,AdName,AdEmail,AdPhone)
	values ( @pass,@user,@email,@phone) 
end

GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12/10/2018 10:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[AdID] [int] IDENTITY(1,1) NOT NULL,
	[AdPass] [varchar](20) NULL,
	[AdName] [varchar](50) NULL,
	[AdPhone] [varchar](20) NULL,
	[AdEmail] [varchar](30) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[City]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](50) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CompanyInfo]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CompanyInfo](
	[ComID] [int] IDENTITY(1,1) NOT NULL,
	[ComPass] [varchar](20) NULL,
	[ComName] [varchar](100) NULL,
	[ComStatus] [bit] NULL,
	[EmailCom] [varchar](50) NULL,
	[AboutCom] [varchar](250) NULL,
	[AddressCom] [varchar](100) NULL,
	[Phone1Com] [varchar](20) NULL,
	[Phone2Com] [varchar](20) NULL,
	[WebsiteCom] [varchar](50) NULL,
 CONSTRAINT [PK_CompanyInfo] PRIMARY KEY CLUSTERED 
(
	[ComID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CompanyListAppyly]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyListAppyly](
	[ComID] [int] NOT NULL,
	[JobID] [int] NOT NULL,
	[USERID] [int] NOT NULL,
	[CHECKUSER] [bit] NULL,
 CONSTRAINT [PK_CompanyListAppyly] PRIMARY KEY CLUSTERED 
(
	[ComID] ASC,
	[JobID] ASC,
	[USERID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Education]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Education](
	[USERID] [int] NOT NULL,
	[EduID] [int] IDENTITY(1,1) NOT NULL,
	[NameEdu] [varchar](50) NULL,
	[FromEdu] [varchar](50) NULL,
	[DecripEdu] [varchar](100) NULL,
 CONSTRAINT [PK_Education] PRIMARY KEY CLUSTERED 
(
	[USERID] ASC,
	[EduID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employment]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employment](
	[UserID] [int] NOT NULL,
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[NameEmp] [varchar](50) NULL,
	[FromEmp] [varchar](50) NULL,
	[DecripEmp] [varchar](100) NULL,
 CONSTRAINT [PK_Employment_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InfoUser]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InfoUser](
	[USERID] [int] IDENTITY(1,1) NOT NULL,
	[USERNAME] [varchar](50) NOT NULL,
	[PASS] [varchar](50) NOT NULL,
	[FULLNAME] [varchar](255) NULL,
	[ABOUTME] [varchar](100) NULL,
	[BIRTHDAY] [date] NULL,
	[Datecreate] [date] NULL,
	[Livein] [varchar](50) NULL,
	[Gender] [char](7) NULL,
	[Skill] [varchar](100) NULL,
	[Email] [varchar](50) NOT NULL,
	[Website] [varchar](50) NULL,
 CONSTRAINT [PK_InfoUser] PRIMARY KEY CLUSTERED 
(
	[USERID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job](
	[JobID] [int] IDENTITY(1,1) NOT NULL,
	[ComID] [int] NULL,
	[JobName] [varchar](100) NULL,
	[JobDetail] [varchar](200) NULL,
	[JobStatus] [bit] NULL,
	[ViewCount] [int] NULL,
	[JobCatID] [int] NULL,
	[PositionID] [int] NULL,
	[CityID] [int] NULL,
	[SalaryMin] [int] NULL,
	[SalaryMax] [int] NULL,
	[PostDay] [date] NULL,
	[StartDay] [date] NULL,
	[EndDay] [date] NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobCatalog]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JobCatalog](
	[JobCataID] [int] IDENTITY(1,1) NOT NULL,
	[CataName] [varchar](50) NULL,
 CONSTRAINT [PK_JobCatalog] PRIMARY KEY CLUSTERED 
(
	[JobCataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Position]    Script Date: 12/10/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Position](
	[PositionID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdID], [AdPass], [AdName], [AdPhone], [AdEmail]) VALUES (1, N'xyz', N'XYZ', N'012312312', N'xyz@gmail.com')
INSERT [dbo].[Admin] ([AdID], [AdPass], [AdName], [AdPhone], [AdEmail]) VALUES (2, N'Admin', N'Zed', N'0988008009', N'ZedAd@gmail.com')
INSERT [dbo].[Admin] ([AdID], [AdPass], [AdName], [AdPhone], [AdEmail]) VALUES (3, N'Admin', N'Zed1', N'111111111', N'nguyen@gmail.com')
INSERT [dbo].[Admin] ([AdID], [AdPass], [AdName], [AdPhone], [AdEmail]) VALUES (4, N'123', N'nam', N'123232', N'123')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([CityID], [CityName]) VALUES (1, N'Ho Chi Minh')
INSERT [dbo].[City] ([CityID], [CityName]) VALUES (2, N'Ha Noi')
INSERT [dbo].[City] ([CityID], [CityName]) VALUES (3, N'Da Nang')
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[CompanyInfo] ON 

INSERT [dbo].[CompanyInfo] ([ComID], [ComPass], [ComName], [ComStatus], [EmailCom], [AboutCom], [AddressCom], [Phone1Com], [Phone2Com], [WebsiteCom]) VALUES (1, N'abc', N'ABC', 1, N'ABC@gmail.com', N'abc', N'abc', N'0287123123', N'0296123213', N'abc.com')
INSERT [dbo].[CompanyInfo] ([ComID], [ComPass], [ComName], [ComStatus], [EmailCom], [AboutCom], [AddressCom], [Phone1Com], [Phone2Com], [WebsiteCom]) VALUES (2, N'def', N'DEF', 1, N'DEF@gmail.com', N'def', N'def', N'0277123124', N'07665533', N'def.com')
SET IDENTITY_INSERT [dbo].[CompanyInfo] OFF
INSERT [dbo].[CompanyListAppyly] ([ComID], [JobID], [USERID], [CHECKUSER]) VALUES (1, 1, 8, 1)
INSERT [dbo].[CompanyListAppyly] ([ComID], [JobID], [USERID], [CHECKUSER]) VALUES (1, 2, 9, 1)
INSERT [dbo].[CompanyListAppyly] ([ComID], [JobID], [USERID], [CHECKUSER]) VALUES (2, 1, 10, 0)
SET IDENTITY_INSERT [dbo].[Education] ON 

INSERT [dbo].[Education] ([USERID], [EduID], [NameEdu], [FromEdu], [DecripEdu]) VALUES (8, 5, N'IT', N'HCMUS', N'IT, design')
INSERT [dbo].[Education] ([USERID], [EduID], [NameEdu], [FromEdu], [DecripEdu]) VALUES (9, 6, N'IT', N'HCMUTE', N'IT, design')
INSERT [dbo].[Education] ([USERID], [EduID], [NameEdu], [FromEdu], [DecripEdu]) VALUES (10, 7, N'IT', N'HCMUIT', N'IT, degisn, network')
SET IDENTITY_INSERT [dbo].[Education] OFF
SET IDENTITY_INSERT [dbo].[InfoUser] ON 

INSERT [dbo].[InfoUser] ([USERID], [USERNAME], [PASS], [FULLNAME], [ABOUTME], [BIRTHDAY], [Datecreate], [Livein], [Gender], [Skill], [Email], [Website]) VALUES (8, N'Sona', N'asdfhjkl', N'Sona', N'sp', CAST(0xB8210B00 AS Date), CAST(0x403E0B00 AS Date), N'Ho Chi Minh', N'Female ', N'C++, Java', N'sona@gmail.com', N'sona.com')
INSERT [dbo].[InfoUser] ([USERID], [USERNAME], [PASS], [FULLNAME], [ABOUTME], [BIRTHDAY], [Datecreate], [Livein], [Gender], [Skill], [Email], [Website]) VALUES (9, N'Zed', N'asdfhjkl', N'Zed', N'assasin', CAST(0x5E210B00 AS Date), CAST(0x763E0B00 AS Date), N'Ha Noi', N'Male   ', N'Ai, Ae', N'zed@gmail.com', N'zed.com')
INSERT [dbo].[InfoUser] ([USERID], [USERNAME], [PASS], [FULLNAME], [ABOUTME], [BIRTHDAY], [Datecreate], [Livein], [Gender], [Skill], [Email], [Website]) VALUES (10, N'Jhin', N'asdfhjkl', N'Jhin', N'ad', CAST(0xB1240B00 AS Date), CAST(0xA23D0B00 AS Date), N'Ha Noi', N'Male   ', N'C++', N'jhin@gmail.com', N'jhin.com')
SET IDENTITY_INSERT [dbo].[InfoUser] OFF
SET IDENTITY_INSERT [dbo].[Job] ON 

INSERT [dbo].[Job] ([JobID], [ComID], [JobName], [JobDetail], [JobStatus], [ViewCount], [JobCatID], [PositionID], [CityID], [SalaryMin], [SalaryMax], [PostDay], [StartDay], [EndDay]) VALUES (1, 1, N'Development', N'C++, Java...', 1, 30, 1, 1, 1, 5000000, 50000000, CAST(0xE33D0B00 AS Date), CAST(0xA93E0B00 AS Date), CAST(0x423F0B00 AS Date))
INSERT [dbo].[Job] ([JobID], [ComID], [JobName], [JobDetail], [JobStatus], [ViewCount], [JobCatID], [PositionID], [CityID], [SalaryMin], [SalaryMax], [PostDay], [StartDay], [EndDay]) VALUES (2, 1, N'Data mining', N'SQL, C++...', 1, 10, 1, 1, 1, 7000000, 70000000, CAST(0xE33D0B00 AS Date), CAST(0xA93E0B00 AS Date), CAST(0x423F0B00 AS Date))
INSERT [dbo].[Job] ([JobID], [ComID], [JobName], [JobDetail], [JobStatus], [ViewCount], [JobCatID], [PositionID], [CityID], [SalaryMin], [SalaryMax], [PostDay], [StartDay], [EndDay]) VALUES (3, 2, N'Designer', N'Ps, Ae, Ai...', 1, 50, 3, 2, 2, 3000000, 30000000, CAST(0x413E0B00 AS Date), CAST(0xC73E0B00 AS Date), CAST(0x9B3F0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Job] OFF
SET IDENTITY_INSERT [dbo].[JobCatalog] ON 

INSERT [dbo].[JobCatalog] ([JobCataID], [CataName]) VALUES (1, N'IT')
INSERT [dbo].[JobCatalog] ([JobCataID], [CataName]) VALUES (2, N'Marketing')
INSERT [dbo].[JobCatalog] ([JobCataID], [CataName]) VALUES (3, N'Design')
SET IDENTITY_INSERT [dbo].[JobCatalog] OFF
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([PositionID], [PositionName]) VALUES (1, N'Flemington')
INSERT [dbo].[Position] ([PositionID], [PositionName]) VALUES (2, N'Lottery')
INSERT [dbo].[Position] ([PositionID], [PositionName]) VALUES (3, N'Parkson')
SET IDENTITY_INSERT [dbo].[Position] OFF
ALTER TABLE [dbo].[CompanyListAppyly]  WITH CHECK ADD  CONSTRAINT [FK_CompanyListAppyly_CompanyInfo_ComID] FOREIGN KEY([ComID])
REFERENCES [dbo].[CompanyInfo] ([ComID])
GO
ALTER TABLE [dbo].[CompanyListAppyly] CHECK CONSTRAINT [FK_CompanyListAppyly_CompanyInfo_ComID]
GO
ALTER TABLE [dbo].[CompanyListAppyly]  WITH CHECK ADD  CONSTRAINT [FK_CompanyListAppyly_InfoUser_USERID] FOREIGN KEY([USERID])
REFERENCES [dbo].[InfoUser] ([USERID])
GO
ALTER TABLE [dbo].[CompanyListAppyly] CHECK CONSTRAINT [FK_CompanyListAppyly_InfoUser_USERID]
GO
ALTER TABLE [dbo].[CompanyListAppyly]  WITH CHECK ADD  CONSTRAINT [FK_CompanyListAppyly_Job_JobID] FOREIGN KEY([JobID])
REFERENCES [dbo].[Job] ([JobID])
GO
ALTER TABLE [dbo].[CompanyListAppyly] CHECK CONSTRAINT [FK_CompanyListAppyly_Job_JobID]
GO
ALTER TABLE [dbo].[Education]  WITH CHECK ADD  CONSTRAINT [FK_Education_InfoUser_USERID] FOREIGN KEY([USERID])
REFERENCES [dbo].[InfoUser] ([USERID])
GO
ALTER TABLE [dbo].[Education] CHECK CONSTRAINT [FK_Education_InfoUser_USERID]
GO
ALTER TABLE [dbo].[Employment]  WITH CHECK ADD  CONSTRAINT [FK_Employment_InfoUser_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[InfoUser] ([USERID])
GO
ALTER TABLE [dbo].[Employment] CHECK CONSTRAINT [FK_Employment_InfoUser_UserID]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_City_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_City_CityID]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_JobCatalog_JobCatID] FOREIGN KEY([JobCatID])
REFERENCES [dbo].[JobCatalog] ([JobCataID])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_JobCatalog_JobCatID]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_Position_PositionID] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([PositionID])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_Position_PositionID]
GO
ALTER TABLE [dbo].[InfoUser]  WITH CHECK ADD  CONSTRAINT [CK_InfoUser_BIRTHDAY] CHECK  (([BIRTHDAY]<=getdate()))
GO
ALTER TABLE [dbo].[InfoUser] CHECK CONSTRAINT [CK_InfoUser_BIRTHDAY]
GO
ALTER TABLE [dbo].[InfoUser]  WITH CHECK ADD  CONSTRAINT [CK_InfoUser_Gender] CHECK  (([Gender]='Male' OR [Gender]='Female'))
GO
ALTER TABLE [dbo].[InfoUser] CHECK CONSTRAINT [CK_InfoUser_Gender]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [CK_Job_PostDay] CHECK  (([PostDay]<=getdate()))
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [CK_Job_PostDay]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [CK_Job_SalaryMax] CHECK  (([SalaryMax]>(0)))
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [CK_Job_SalaryMax]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [CK_Job_SalaryMin] CHECK  (([SalaryMin]>(0)))
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [CK_Job_SalaryMin]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [CK_Job_StartDay] CHECK  (([StartDay]<=getdate()))
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [CK_Job_StartDay]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [CK_Job_ViewCount] CHECK  (([ViewCount]>=(0)))
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [CK_Job_ViewCount]
GO
USE [master]
GO
ALTER DATABASE [Jobs] SET  READ_WRITE 
GO
