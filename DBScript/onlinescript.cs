USE [master]
GO
/****** Object:  Database [OnlineExam]    Script Date: 5/14/2018 10:19:49 PM ******/
CREATE DATABASE [OnlineExam]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OnlineExam', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\OnlineExam.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OnlineExam_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\OnlineExam_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OnlineExam] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineExam].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineExam] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineExam] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineExam] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineExam] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineExam] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineExam] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineExam] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineExam] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineExam] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineExam] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineExam] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineExam] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineExam] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineExam] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineExam] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OnlineExam] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineExam] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineExam] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineExam] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineExam] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineExam] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [OnlineExam] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineExam] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OnlineExam] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineExam] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineExam] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineExam] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineExam] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnlineExam] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OnlineExam', N'ON'
GO
ALTER DATABASE [OnlineExam] SET QUERY_STORE = OFF
GO
USE [OnlineExam]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [OnlineExam]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 5/14/2018 10:19:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Answer]    Script Date: 5/14/2018 10:19:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionID] [int] NULL,
	[AnswerText] [varchar](max) NULL,
	[ChoiceID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Choice]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Choice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ChoiceText] [varchar](max) NOT NULL,
	[QuestionID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamPaper]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamPaper](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ExamID] [int] NOT NULL,
	[PaperName] [varchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LNK_ROLE_PERMISSION]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LNK_ROLE_PERMISSION](
	[RoleId] [int] NOT NULL,
	[PermissionId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.LNK_ROLE_PERMISSION] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LNK_USER_ROLE]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LNK_USER_ROLE](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.LNK_USER_ROLE] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISSIONS]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISSIONS](
	[PermissionId] [int] IDENTITY(1,1) NOT NULL,
	[PermissionDescription] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.PERMISSIONS] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 5/14/2018 10:19:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionText] [varchar](max) NOT NULL,
	[QuestionTypeID] [int] NOT NULL,
	[ExamPaperID] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionType]    Script Date: 5/14/2018 10:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 5/14/2018 10:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLES](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[LastModified] [datetime] NOT NULL,
	[IsSysAdmin] [bit] NOT NULL,
	[RoleDescription] [nvarchar](max) NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.ROLES] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAnswer]    Script Date: 5/14/2018 10:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAnswer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[QuestionId] [int] NULL,
	[ChoiceID] [int] NULL,
	[Answer] [varchar](max) NULL,
	[ExamPaperID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserExam]    Script Date: 5/14/2018 10:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserExam](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[ExamPaperID] [int] NULL,
	[ExpectedStartDate] [datetime] NULL,
	[isAttempted] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[SubmittedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 5/14/2018 10:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[LastModified] [datetime] NOT NULL,
	[Inactive] [bit] NOT NULL,
	[Firstname] [nvarchar](max) NULL,
	[Lastname] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.USERS] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201804121349195_InitialCreate', N'OnlineExam.Models.RBACDbContext', 0x1F8B0800000000000400ED5D5B6FECB6117E2FD0FF20E8A92D1CAFED8314A9B19B60CFDA6E16F10D5E9FA06F062DD16B2112B59128C746D15FD687FCA4FC8592BA2DAF1229696FE8C1010E6C5E86C3E1C7CB8C66C67FFCF7F7F10FEF51E8BCC1240D6234714F8F4F5C07222FF603B49CB8197EF9E63BF787EFFFFCA7F1A51FBD3B3F57ED3ED176A4274A27EE2BC6ABF3D128F55E6104D2E328F092388D5FF0B1174723E0C7A3B393937F8C4E4F47909070092DC7193F64080711CC7F21BFCE62E4C115CE407813FB304CCB7252B3C8A93AB72082E90A7870E23E7C9ECEDE3E1D170D5D671A068030B180E18BEB0084620C3061F1FC4B0A173889D172B12205207CFC5841D2EE0584292C593F5F37379DC5C9199DC568DDB122E565298E234B82A79F4AB18CC4EE9D84EBD6622382BB2402C61F74D6B9F026EEFDE5C3CD7CB198DFDDBA8E38DCF92C4C685341BAC7EB3E474E51735463804085FE3B72665988B3044E10CC7002C223E73E7B0E03EF27F8F118FF02D1046561C8B2469823755C0129BA4FE2154CF0C7037CA918864914A474ACB9EF3A239EC24824511350F62E263747F8D399EBDC1286C073086B34308258E03881FF8408260043FF1E600C13B298731FE6F294F8D08E7A01532F0956C56216C3133C925DE53A37E0FD1AA2257E9DB8DF926D7415BC43BF2A2839FA8202B207491F9C6450C1B1C0C52D780B96F904047E1EEEAE2F17AEF300C3BC367D0D56C55E399EAE566491F2D28738844FEBA526EDAF9238A2A513B7A1D9D32348961093D9C5ED6D1771967802E3E3D11AA48DD015089BE357E8B803107781EE36017B0D524C8415BC04B01EF582507A24A7733BEE44C6D3C5473AF5A3A086FCE798881D206B4A74B5CC7610F9D1680B358F47FF6F18E4ECDBBF6F769F72BB6F33BBB5DA8126BBB5DAD9A6EC93CB36498D182F5BEA59CE1BB4325BB452B1D9E550A1D43A1F2C55E71D1C2E7468F9805136A51C76398BAA219ACFA3F6CD6C4D437FA5E50BD50CB56A4D9E8AC64AB4716D9A00C7371C12739DF1F6F522DBF0458680878337D8F71ABB0A9214A3E6BB65980B8C4E7F2B035D46200807B82A0D46215AE14B9044EBF5ECBA0CF7204D7F8B13FF4790BE6E5C400BE8650901EC028368B5F1D1EE5F63046FB3E8999E26DB1B6BB0A579FC2DBE227B2D4E2E11EDD59BDE75ECFD1267F812F974F37FC19E7C16181218849DA9E7C134BD226086FE2CCE10EE7793D2B37FD74FD5590882A8F5B147397DAA9A6AEFDFB245DBED5B35B37D965EC7CB0099B15A35D5B35AB46865B56C66CB2A2566C669D952CF68DEA095CFA2D590AF997C913A3F69F2DE5FDF351B7980E7B2A504367E45E423FD0CC26CE8A1BA8232DF8E9D4199F7DE0128F37149F15BE0D37BDD40BFAB1A13F246EDD5AA633BF405CEB46B7C7AF6DD20D790F80461A7B9EDC1EDB7A20EB5D3348DBD208799DAC4C9197878A6C8D3C6B1B0F6143252986288C4087A035A46389CB87F93A66F36526D055E8FC47E6A681C643C6224612C205EBB37E059A3EA2B45B3B60575128FDA5860BE0AA7AEB877EFD0050C2186CED42B3E2CCD40EA015F462BC19ACF9790ED0E137ACD00AA4BA5E4880A1096CF860079C10A84869311FA1B5EAA94BF7A24B1E602AE20A2F7A1E1D299B0A036785136EAD104F1B549AB1B5819ABA7E9EE124CA0BBC14E1B7BCDD036DF457D312A4B6CBB0095457248E864D534C3D34DD2D9B400D83E3E55CAA29EBF5261D934421542DBFE192A48C58401EDD7855D60B4D4CF4D31202AEBFB8651C14AA0E7AFD45FB682515E683BC0282F9583C368619931858060A6D93784F2F6A15DDFF2B2C476004F4E247B86CE42CF247D30E90193EA99F1793ABB78A6A5F01D2BAC2084C1D21092963AB1080F4A7501B1CA4D61ADDA2AD43E4957E20995464C8984F4C26DA1A300630BD935665B48979E0A6DB46C59AC6CE26D74CBC7891DF1CA8ADD46BCBC5504E20CB49423C89E274C0F0347157117D85932EAA9D7E891B6959DC18221C84D4A3C3479B1D8894C70446894578359C3CEB0C14C4CBD3FCC04A73665B42D433F79B13E42EDE052A8D5168A752F40F14AB0A5C4FB63AAFEB4D68A28A57667A3DF31732B17C61C3EA22EA69753359FC105551D89ED8252A918364A462F41090A815E50D57C06175489D47639299EB9160FDD5E52E21FA5C3EDBACA4E5FBF9FEABAF1A88840280BC6234DA8C2F806AC56015A32A10B6589B328E21666DF2CECBDFAA382C6C8E3042EBEF6EA91709C8025146AC9D084D3DC15E90260F00CE8578A991F49CDF8D7A2E6E1518D253F08E565AC1E21551FFAF3FA61AA0A33503CABCBCE576466117D9BE7DF539577B7DCD9A101242004496370C02C0EB308B5071D9851E4DC96D5A4B926F218E3913067497D90442BE979FC6A19ADA56E5F9BAEA2F876B75FCA560A3AE98BABA833AFEA29F0EE832C2DBEC69C22EB0CCFD263CBCDA9D119699125559AD32DBC89586245C9DEA05279B20F02D25A13EC05543D159DC82BAB002B749DA5A01910E6B0DFD1E2E91EE81D57ABFF4A753F52EC576803474AED96CC1D2875A93925C6319925C514DBCD5326B52E35A754FA16B364CA224B1A8C7BAA448CA9B3B8DE390F62EE56E76ACC290A6EC22C49A1CA824BD619986392ADE8444F2351750BF31164F75F96BA5C6B814AD9119883A75CDD81B68267B1CE9CAAC2579825ACA836A7BD761C16CFB4FDBEEEB5C68B8E37486155ED7D8D68C898DE2576F7C830EF05C6079425C4145BD22ABD3C256265F9BE224A6BE5E988A8C294DE1B511A32FA138873C3E40FA046DF513D4DCEB7923BE49B7C4BF5F4EC70BB6974F0B61F2D44E46F1C86EA2EDFA945B3D5DB2CA8F14BBC17DA3F8EC8D2ECA526E71F8AABBEFD18D47E2D1DD42EA3675834FAC9D8906C7F62931A99B50D50B0F58D4BBB5B7BEE12C9105734719D6A8B91C7DF478A61744C1B1C2F7E0D676100E9555F35B801287881292EFCCBDDB393D3332107CAFEE42319A5A91F2AEC96EAA424FCB2ED2843484065DD1AB161EBB4DE941404BD81C47B05899416A49363796BEA8C0E52569F12EDF2ADFA6D50B2AAA05F9F90C6C364AF780EF050992BAA65FE4B04DEFFCA12B5CD4EB1C68BE4CD31473E7C9FB8FFCE7B9DE79F50E84F79F191334FBFA0E0D78C543C92219DFFC8518383234E6D1BDBD3DC063940DB643AFFD753D1EBC8B94BC8717CEE9C5049F64A88603A70D1CB62E0CE6909065BAE4E6BB0DF87849019A0CB11216505E875388891FFBD8871D1FDCAAB493829BA07F377919C2A90BFD77C95C1FABD282A02F287A23788087501F75D686983ED55DBCB08CBCAE0FB2EAC6903EFF323A667D8BDF91D5CF5DCED1DAC30576D23387A23A7F9CE2E6D2988BAD7B69603A52DC8F50B86EE8083038B47565E5C795070FF70E3C1686F09C85D35C57E9AB9D6B234B412BFA5A7B485F5C06078B6EF004B69154DAE3419EA1D5DF72FFE948D32D0F3661C82EE0C1382DA33EAB36BE469A3E7DCFE869D1A9989190868D65CBFC8FF5750B404419B297D4B586C6363FB017C9AE08B43391CD7914DBB8ED6DBD181D8E0D0B7E747A1557E88AFA8FB8ABA218E3BCBBC0FFB17A35C8648EE4582879EF1C05D81A7F367DAF34879BB6C0EFB87BC327E762FD236EC08793ABFA73D479E227EE09080B71F37ED0E61677CD3EE3CF7821C7427AEB12EB7424B6A85C26768E2FACF318142612D6A0A606FC81950C0A53D0B836AC8F24FCBD8276830CDCFA01AF4FAF6A7A72F8BCB87273ABAEDE026C91C5483D201AD675ABE3D0CD33CA8869DA6AB5B881B82A34D924118E78268E6401375DC02AD464837B4D5AD3C5DF4A7862C23B6092CEAA064AB3C161AA7CB2685AD21C6D122E9802CCE16DFD2E15333A8F268D8094FED10AAB1F5A9C37C0F46641BCEFE3114B6C483591BE27838A93E0E572C1BCEEED134191BC170D79B3E44E690F2790C251AEEDED5C77A1C4E068FA10433F066B248DA213BE893E73EF3274889D69106CB3509FA074911F4B8877EDD668E5EE24ADF1038AA9A08DF8A6F20063ED102A6090E5E80874935F54ECAD396E73E20D447EE19FA737497E15586C99461F41C729E13546F691A3FCF4CC2F33CBECB5D90D321A640D80CA857D71DFA9C05A15FF37DA5F84CAD214115A2D21188AE25A60E41CB8F9AD26D8C0C0995E2ABF5B84718AD42422CBD430B405D33ED7923F0BB864BE07DAC5D497444DA178217FBF82200CB0444694963DD9FFC4A30EC47EFDFFF0FEECDA57989770000, N'6.1.3-40302')
SET IDENTITY_INSERT [dbo].[Answer] ON 

INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1, 1, NULL, 2)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (2, 2, NULL, NULL)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (3, 5, NULL, 18)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (4, 58, NULL, 136)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (7, 62, NULL, 153)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (8, 69, NULL, 183)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (9, 88, NULL, 257)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1003, 1003, NULL, 1010)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1004, 1007, NULL, 1015)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1005, 1008, NULL, 1020)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1006, 1010, NULL, 1026)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1007, 1012, NULL, 1030)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1008, 1013, NULL, 1034)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1009, 1014, NULL, 1038)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1010, 1015, NULL, 1041)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1011, 1016, NULL, 1046)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1012, 1017, NULL, 1050)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1013, 1018, NULL, 1054)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1018, 1023, NULL, 1074)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1019, 1024, NULL, 1078)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1020, 1025, NULL, 1083)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1021, 1026, NULL, 1087)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1022, 1027, NULL, 1090)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1023, 1028, NULL, 1094)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1024, 1029, NULL, 1098)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1025, 1030, NULL, 1102)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1026, 1031, NULL, 1106)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1027, 1032, NULL, 1110)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1028, 1033, NULL, 1115)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1029, 1034, NULL, 1119)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1030, 1035, NULL, 1123)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1031, 1036, NULL, 1125)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1032, 1037, NULL, 1130)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1033, 1038, NULL, 1133)
INSERT [dbo].[Answer] ([ID], [QuestionID], [AnswerText], [ChoiceID]) VALUES (1034, 1039, NULL, 1137)
SET IDENTITY_INSERT [dbo].[Answer] OFF
SET IDENTITY_INSERT [dbo].[Choice] ON 

INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1, N'choice1', 1)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (2, N'choice2', 1)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (3, N'choice3', 1)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (4, N'choice4', 1)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (5, N'choice1', 2)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (6, N'choice2', 2)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (7, N'choice3', 2)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (8, N'choice4', 2)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (17, N'abhi_ch1', 5)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (18, N'abhi_ch2', 5)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (19, N'abhi_ch3', 5)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (20, N'abhi_ch4', 5)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (136, N'abhi1_ch1', 58)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (137, N'abhi1_ch2', 58)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (138, N'abhi1_ch3', 58)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (139, N'abhi11_ch4', 58)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (152, N'option1', 62)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (153, N'option2', 62)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (154, N'option3', 62)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (155, N'option4', 62)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (180, N'option12', 69)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (181, N'option22', 69)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (182, N'option32', 69)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (183, N'option42', 69)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (256, N'option123', 88)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (257, N'option223', 88)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (258, N'option323', 88)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (259, N'option423', 88)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1009, N'option1', 1003)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1010, N'option2', 1003)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1011, N'opt3', 1003)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1012, N'opd', 1003)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1013, N'jhjhj', 1007)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1014, N'se', 1007)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1015, N'ser', 1007)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1016, N'de', 1007)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1017, N'dertt', 1008)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1018, N'derr', 1008)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1019, N'derrser', 1008)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1020, N'derer', 1008)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1025, N'ser', 1010)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1026, N'ssf', 1010)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1027, N'thichie3', 1010)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1028, N'choice4', 1010)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1029, N'ch1', 1012)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1030, N'che2', 1012)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1031, N'che3', 1012)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1032, N'che4', 1012)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1033, N'ch1', 1013)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1034, N'che2', 1013)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1035, N'che3', 1013)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1036, N'che4', 1013)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1037, N'ch1', 1014)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1038, N'che2', 1014)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1039, N'che3', 1014)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1040, N'che4', 1014)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1041, N'kldl', 1015)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1042, N'ldl', 1015)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1043, N'lfsldk', 1015)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1044, N'klfs', 1015)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1045, N'fdsf', 1016)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1046, N'ddddsd', 1016)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1047, N'fdsf', 1016)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1048, N'sf', 1016)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1049, N'ch1', 1017)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1050, N'che2', 1017)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1051, N'che3', 1017)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1052, N'che4', 1017)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1053, N'dsa', 1018)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1054, N'saffds', 1018)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1055, N'fs', 1018)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1056, N'fsdfsd', 1018)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1073, N'eew', 1023)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1074, N'wee', 1023)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1075, N'eww', 1023)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1076, N'www', 1023)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1077, N'eew', 1024)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1078, N'wee', 1024)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1079, N'eww', 1024)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1080, N'www', 1024)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1081, N'wdd', 1025)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1082, N'ddd', 1025)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1083, N'ddf', 1025)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1084, N'dfddfd', 1025)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1085, N'wdd', 1026)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1086, N'ddd', 1026)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1087, N'ddf', 1026)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1088, N'dfddfd', 1026)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1089, N'sddddf', 1027)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1090, N'ss', 1027)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1091, N'sss', 1027)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1092, N'sdfs', 1027)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1093, N'dewr', 1028)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1094, N'weew', 1028)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1095, N'wdd', 1028)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1096, N'weewss', 1028)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1097, N'sddddf', 1029)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1098, N'ss', 1029)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1099, N'sss', 1029)
GO
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1100, N'sdfs', 1029)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1101, N'sddddf', 1030)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1102, N'ss', 1030)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1103, N'sss', 1030)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1104, N'sdfs', 1030)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1105, N'sddddf', 1031)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1106, N'ss', 1031)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1107, N'sss', 1031)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1108, N'sdfs', 1031)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1109, N'sddddf', 1032)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1110, N'ss', 1032)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1111, N'sss', 1032)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1112, N'sdfs', 1032)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1113, N'jfkj', 1033)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1114, N'fkjak', 1033)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1115, N'fjk', 1033)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1116, N'fkj', 1033)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1117, N'jfkj', 1034)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1118, N'fkjak', 1034)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1119, N'fjk', 1034)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1120, N'fkj', 1034)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1121, N'wdd', 1035)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1122, N'ddd', 1035)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1123, N'ddf', 1035)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1124, N'dfddfd', 1035)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1125, N'ww', 1036)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1126, N'wwew', 1036)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1127, N'we', 1036)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1128, N'we', 1036)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1129, N's''', 1037)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1130, N'lksadl', 1037)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1131, N'jdlksj', 1037)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1132, N'dwd', 1037)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1133, N'se', 1038)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1134, N'e', 1038)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1135, N'e', 1038)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1136, N'zzz', 1038)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1137, N'se', 1039)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1138, N'e', 1039)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1139, N'e', 1039)
INSERT [dbo].[Choice] ([ID], [ChoiceText], [QuestionID]) VALUES (1140, N'zzz', 1039)
SET IDENTITY_INSERT [dbo].[Choice] OFF
SET IDENTITY_INSERT [dbo].[Exam] ON 

INSERT [dbo].[Exam] ([ID], [Name], [UpdateDate]) VALUES (1, N'E', CAST(N'2018-04-13T00:30:30.293' AS DateTime))
INSERT [dbo].[Exam] ([ID], [Name], [UpdateDate]) VALUES (2, N'E', CAST(N'2018-04-13T00:30:40.790' AS DateTime))
INSERT [dbo].[Exam] ([ID], [Name], [UpdateDate]) VALUES (3, N'a', CAST(N'2018-04-13T00:33:26.430' AS DateTime))
INSERT [dbo].[Exam] ([ID], [Name], [UpdateDate]) VALUES (4, N'abhiExam1', CAST(N'2018-04-13T00:35:11.080' AS DateTime))
INSERT [dbo].[Exam] ([ID], [Name], [UpdateDate]) VALUES (5, N' ', CAST(N'2018-04-13T00:36:22.250' AS DateTime))
INSERT [dbo].[Exam] ([ID], [Name], [UpdateDate]) VALUES (6, N'', CAST(N'2018-04-13T00:36:46.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Exam] OFF
SET IDENTITY_INSERT [dbo].[ExamPaper] ON 

INSERT [dbo].[ExamPaper] ([ID], [ExamID], [PaperName], [CreatedDate]) VALUES (1, 4, N'Examp1', CAST(N'2018-04-14T17:56:33.473' AS DateTime))
INSERT [dbo].[ExamPaper] ([ID], [ExamID], [PaperName], [CreatedDate]) VALUES (3, 1, N'Examp2', CAST(N'2018-04-14T17:57:08.783' AS DateTime))
SET IDENTITY_INSERT [dbo].[ExamPaper] OFF
INSERT [dbo].[LNK_ROLE_PERMISSION] ([RoleId], [PermissionId]) VALUES (2, 1)
INSERT [dbo].[LNK_USER_ROLE] ([UserId], [RoleId]) VALUES (1, 1)
INSERT [dbo].[LNK_USER_ROLE] ([UserId], [RoleId]) VALUES (2, 2)
SET IDENTITY_INSERT [dbo].[PERMISSIONS] ON 

INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (1, N'Home-Reports')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (2, N'Account-Login')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (3, N'Account-OTP4PhoneVerification')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (4, N'Account-OTP4EmailVerification')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (5, N'Account-RequestEmailVerification')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (6, N'Account-Register')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (7, N'Account-ForgotPassword')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (8, N'Account-ForgotPasswordConfirmation')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (9, N'Account-ResetPassword')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (10, N'Account-ResetPasswordConfirmation')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (11, N'Account-ExternalLogin')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (12, N'Account-LogOff')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (13, N'Account-ExternalLoginFailure')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (14, N'Admin-Index')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (15, N'Admin-UserDetails')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (16, N'Admin-UserEdit')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (17, N'Admin-DeleteUserRole')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (18, N'Admin-filter4Users')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (19, N'Admin-filterReset')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (20, N'Admin-DeleteUserReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (21, N'Admin-DeleteUserRoleReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (22, N'Admin-AddUserRoleReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (23, N'Admin-RoleIndex')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (24, N'Admin-RoleDetails')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (25, N'Admin-RoleCreate')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (26, N'Admin-RoleEdit')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (27, N'Admin-DeleteUserFromRoleReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (28, N'Admin-AddUser2RoleReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (29, N'Admin-RoleDelete')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (30, N'Admin-PermissionIndex')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (31, N'Admin-PermissionDetails')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (32, N'Admin-PermissionCreate')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (33, N'Admin-PermissionEdit')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (34, N'Admin-DeletePermissionReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (35, N'Admin-AddPermission2RoleReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (36, N'Admin-AddAllPermissions2RoleReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (37, N'Admin-DeletePermissionFromRoleReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (38, N'Admin-DeleteRoleFromPermissionReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (39, N'Admin-AddRole2PermissionReturnPartialView')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (40, N'Admin-PermissionsImport')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (41, N'Home-Index')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (42, N'Home-About')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (43, N'Manage-AddPhoneNumber')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (44, N'Manage-ChangePassword')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (45, N'Manage-SetPassword')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (46, N'Manage-LinkLogin')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (47, N'Unauthorised-Index')
INSERT [dbo].[PERMISSIONS] ([PermissionId], [PermissionDescription]) VALUES (48, N'Unauthorised-Error')
SET IDENTITY_INSERT [dbo].[PERMISSIONS] OFF
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1, N'Question 1wwe t', 1, 1, CAST(N'2018-04-14T17:59:56.060' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (2, N'Question 1wwe t', 1, 1, CAST(N'2018-04-14T18:01:31.810' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (5, N'abhiquestion1', 1, 1, CAST(N'2018-04-15T22:53:08.870' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (58, N'abhi1question1', 2, 3, CAST(N'2018-04-16T01:10:09.683' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (62, N'abhiquest1', 1, 1, CAST(N'2018-04-16T01:19:31.877' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (69, N'abhiquest12', 1, 1, CAST(N'2018-04-16T01:27:38.233' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (88, N'abhiquest123', 1, 1, CAST(N'2018-04-16T01:50:38.357' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1003, N'this is question1', 2, 1, CAST(N'2018-04-21T18:32:17.720' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1007, N'jju', 1, 3, CAST(N'2018-04-21T18:52:26.277' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1008, N'thie  is quesr 2', 4, 1, CAST(N'2018-04-21T18:53:33.620' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1010, N'question 34', 2, 3, CAST(N'2018-04-23T06:22:06.703' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1012, N'questo2', 2, 3, CAST(N'2018-04-23T06:25:57.327' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1013, N'questo2', 2, 3, CAST(N'2018-04-23T06:27:43.970' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1014, N'questo2', 2, 3, CAST(N'2018-04-23T06:35:32.853' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1015, N'this i siquestion 4', 3, 3, CAST(N'2018-04-23T06:41:30.220' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1016, N'seff', 1, 1, CAST(N'2018-04-23T06:52:23.903' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1017, N'questo2', 2, 3, CAST(N'2018-04-23T07:01:43.287' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1018, N'dasdada', 1, 1, CAST(N'2018-04-23T07:07:46.333' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1023, N'ddw', 1, 1, CAST(N'2018-04-23T07:14:24.610' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1024, N'ddw', 1, 1, CAST(N'2018-04-23T07:30:26.707' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1025, N'sser', 1, 1, CAST(N'2018-04-23T07:31:27.750' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1026, N'sser', 1, 1, CAST(N'2018-04-23T07:31:55.630' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1027, N'ser', 1, 1, CAST(N'2018-04-23T07:32:38.210' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1028, N'ser', 1, 1, CAST(N'2018-04-23T07:37:58.307' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1029, N'ser', 1, 1, CAST(N'2018-04-23T07:38:54.980' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1030, N'ser', 1, 1, CAST(N'2018-04-23T07:49:11.793' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1031, N'ser', 1, 1, CAST(N'2018-04-23T07:49:41.400' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1032, N'ser', 1, 1, CAST(N'2018-04-23T07:50:35.763' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1033, N'me,e', 1, 3, CAST(N'2018-04-23T08:03:24.543' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1034, N'me,e', 1, 3, CAST(N'2018-04-23T08:04:42.087' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1035, N'sser', 1, 1, CAST(N'2018-04-23T08:07:16.367' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1036, N'ww', 1, 1, CAST(N'2018-04-23T08:18:29.590' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1037, N'jjj', 2, 1, CAST(N'2018-04-23T09:00:51.480' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1038, N'ee', 1, 1, CAST(N'2018-04-23T09:09:41.357' AS DateTime))
INSERT [dbo].[Question] ([ID], [QuestionText], [QuestionTypeID], [ExamPaperID], [CreatedDate]) VALUES (1039, N'ee', 1, 1, CAST(N'2018-04-23T09:10:39.173' AS DateTime))
SET IDENTITY_INSERT [dbo].[Question] OFF
SET IDENTITY_INSERT [dbo].[QuestionType] ON 

INSERT [dbo].[QuestionType] ([ID], [TypeName]) VALUES (1, N'Section1')
INSERT [dbo].[QuestionType] ([ID], [TypeName]) VALUES (2, N'Section2')
INSERT [dbo].[QuestionType] ([ID], [TypeName]) VALUES (3, N'Section3')
INSERT [dbo].[QuestionType] ([ID], [TypeName]) VALUES (4, N'Section3')
SET IDENTITY_INSERT [dbo].[QuestionType] OFF
SET IDENTITY_INSERT [dbo].[ROLES] ON 

INSERT [dbo].[ROLES] ([RoleId], [LastModified], [IsSysAdmin], [RoleDescription], [Name]) VALUES (1, CAST(N'2018-04-12T19:19:20.670' AS DateTime), 1, N'Allows system administration of Users/Roles/Permissions', N'System Administrator')
INSERT [dbo].[ROLES] ([RoleId], [LastModified], [IsSysAdmin], [RoleDescription], [Name]) VALUES (2, CAST(N'2018-04-12T19:19:21.817' AS DateTime), 0, N'Default role with limited permissions', N'Default User')
INSERT [dbo].[ROLES] ([RoleId], [LastModified], [IsSysAdmin], [RoleDescription], [Name]) VALUES (3, CAST(N'2018-04-18T00:10:14.783' AS DateTime), 0, N'this is sample role', N'sample role')
SET IDENTITY_INSERT [dbo].[ROLES] OFF
SET IDENTITY_INSERT [dbo].[UserAnswer] ON 

INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (1, 1, 1, 2, NULL, 1)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (2, 1, 1, 1, NULL, 1)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (5, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (6, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (7, 1, 1010, 1028, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (8, 1, 1012, 1030, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (9, 1, 1015, 1042, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (10, 1, 1017, 1051, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (11, 1, 1015, 1042, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (12, 1, 1017, 1050, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (13, 1, 1017, 1051, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (14, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (15, 1, 1012, 1030, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (16, 1, 1015, 1044, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (17, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (18, 1, 1013, 1035, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (19, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (21, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (22, 1, 1017, 1051, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (23, 1, 1010, 1028, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (24, 1, 1012, 1030, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (25, 1, 1033, 1113, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (26, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (27, 1, 1012, 1032, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (28, 1, 1012, 1031, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (29, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (30, 1, 1010, 1026, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (31, 1, 1007, 1015, NULL, 3)
INSERT [dbo].[UserAnswer] ([ID], [UserID], [QuestionId], [ChoiceID], [Answer], [ExamPaperID]) VALUES (32, 1, 1012, 1030, NULL, 3)
SET IDENTITY_INSERT [dbo].[UserAnswer] OFF
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([UserId], [LastModified], [Inactive], [Firstname], [Lastname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (1, CAST(N'2018-04-12T20:35:23.280' AS DateTime), 0, N'System', N'Administrator', N'admin@somedomain.com', 1, N'AElaRlWzPcSJvjd69vJiUtT/sWn/y3y/ZJb7g39KSELHsgnw4aHY0KkEhq8rzoi+Aw==', N'455a893e-c2b2-4eda-886f-2e5ceec39aff', NULL, 0, 0, NULL, 0, 0, N'Admin')
INSERT [dbo].[USERS] ([UserId], [LastModified], [Inactive], [Firstname], [Lastname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (2, CAST(N'2018-04-12T19:19:21.570' AS DateTime), 0, N'Default', N'User', N'defaultuser@somedomain.com', 1, N'APf6izZNDuoToChO84p+mZTd5ipp0iBu7TYEcbARNTkrV+X/S93ZrWci7Od8nloK1w==', N'99066b70-6b79-41ac-8c8b-7e7a72a7b4a5', NULL, 0, 0, NULL, 0, 0, N'DefaultUser')
INSERT [dbo].[USERS] ([UserId], [LastModified], [Inactive], [Firstname], [Lastname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (3, CAST(N'2018-04-12T19:19:21.617' AS DateTime), 0, N'Guest', N'User', N'guest@somedomain.com', 1, N'AKl9/bx0D+atnLTLiEhF8QGa3f7pDAIyTdjE6wrRzsgGEmnzdgrxemFe3pJuzxxzng==', N'48720e01-7701-4831-b36e-eb3d6cbbb70d', NULL, 0, 0, NULL, 0, 0, N'Guest')
INSERT [dbo].[USERS] ([UserId], [LastModified], [Inactive], [Firstname], [Lastname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (4, CAST(N'2018-04-12T19:19:02.197' AS DateTime), 0, N'abhi', N'umar', N'umar.abhishek6@gmail.com', 0, N'ALcS94THI/yUp3gvD822QxsimXOqQVc/3uoXWEDzqElCyo3z3A0phB13ZeaAfW5QWQ==', N'bb222ca1-5c3e-4863-8378-071112f9ed93', NULL, 0, 0, NULL, 1, 0, N'abhiumar')
INSERT [dbo].[USERS] ([UserId], [LastModified], [Inactive], [Firstname], [Lastname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (5, CAST(N'2018-04-12T19:45:36.903' AS DateTime), 0, N'abhi', N'umar', N'abhishekkumar.umar@globallogic.com', 0, N'AIgeBOlVnhzFthtn4W0PUcrjGkEB4dtjKWi0scU3mGBBy0r+07C+BzsczfLphYtEcA==', N'efe9eebb-7ac4-42ad-b42c-1d0aaa66e446', NULL, 0, 0, NULL, 1, 0, N'abhiumar1')
SET IDENTITY_INSERT [dbo].[USERS] OFF
/****** Object:  Index [IX_UserId]    Script Date: 5/14/2018 10:19:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 5/14/2018 10:19:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PermissionId]    Script Date: 5/14/2018 10:19:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_PermissionId] ON [dbo].[LNK_ROLE_PERMISSION]
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoleId]    Script Date: 5/14/2018 10:19:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[LNK_ROLE_PERMISSION]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoleId]    Script Date: 5/14/2018 10:19:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[LNK_USER_ROLE]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 5/14/2018 10:19:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[LNK_USER_ROLE]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/14/2018 10:19:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[ROLES]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/14/2018 10:19:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[USERS]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD FOREIGN KEY([ChoiceID])
REFERENCES [dbo].[Choice] ([ID])
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.USERS_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[USERS] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.USERS_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.USERS_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[USERS] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.USERS_UserId]
GO
ALTER TABLE [dbo].[Choice]  WITH CHECK ADD FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[ExamPaper]  WITH CHECK ADD FOREIGN KEY([ExamID])
REFERENCES [dbo].[Exam] ([ID])
GO
ALTER TABLE [dbo].[LNK_ROLE_PERMISSION]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LNK_ROLE_PERMISSION_dbo.PERMISSIONS_PermissionId] FOREIGN KEY([PermissionId])
REFERENCES [dbo].[PERMISSIONS] ([PermissionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LNK_ROLE_PERMISSION] CHECK CONSTRAINT [FK_dbo.LNK_ROLE_PERMISSION_dbo.PERMISSIONS_PermissionId]
GO
ALTER TABLE [dbo].[LNK_ROLE_PERMISSION]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LNK_ROLE_PERMISSION_dbo.ROLES_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[ROLES] ([RoleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LNK_ROLE_PERMISSION] CHECK CONSTRAINT [FK_dbo.LNK_ROLE_PERMISSION_dbo.ROLES_RoleId]
GO
ALTER TABLE [dbo].[LNK_USER_ROLE]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LNK_USER_ROLE_dbo.ROLES_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[ROLES] ([RoleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LNK_USER_ROLE] CHECK CONSTRAINT [FK_dbo.LNK_USER_ROLE_dbo.ROLES_RoleId]
GO
ALTER TABLE [dbo].[LNK_USER_ROLE]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LNK_USER_ROLE_dbo.USERS_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[USERS] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LNK_USER_ROLE] CHECK CONSTRAINT [FK_dbo.LNK_USER_ROLE_dbo.USERS_UserId]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD FOREIGN KEY([ExamPaperID])
REFERENCES [dbo].[ExamPaper] ([ID])
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD FOREIGN KEY([QuestionTypeID])
REFERENCES [dbo].[QuestionType] ([ID])
GO
ALTER TABLE [dbo].[UserAnswer]  WITH CHECK ADD FOREIGN KEY([ChoiceID])
REFERENCES [dbo].[Choice] ([ID])
GO
ALTER TABLE [dbo].[UserAnswer]  WITH CHECK ADD FOREIGN KEY([ExamPaperID])
REFERENCES [dbo].[ExamPaper] ([ID])
GO
ALTER TABLE [dbo].[UserAnswer]  WITH CHECK ADD FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[UserAnswer]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[UserExam]  WITH CHECK ADD FOREIGN KEY([ExamPaperID])
REFERENCES [dbo].[ExamPaper] ([ID])
GO
ALTER TABLE [dbo].[UserExam]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[USERS] ([UserId])
GO
/****** Object:  StoredProcedure [dbo].[uspgetQuestionsByExamPaperId]    Script Date: 5/14/2018 10:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  procedure [dbo].[uspgetQuestionsByExamPaperId]
(
@exampaperid int 
)
As

Begin
SET NOCOUNT ON ;
SET XACT_ABORT ON;

     select Q.ID as QuestionID,Q.QuestionText,Q.QuestionTypeID,Q.ExamPaperID,C.ID as ChioceID,C.ChoiceText from Question as Q 
	-- INNER JOIN  ExamPaper as EP on Q.ExamPaperID=Ep.ID
	 INNER JOIN Choice C on C.QuestionID=Q.ID

	 where Q.ExamPaperID =3

End
GO
/****** Object:  StoredProcedure [dbo].[uspInsertExam]    Script Date: 5/14/2018 10:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspInsertExam]
(
@Name varchar(max)
)
As 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
insert into  dbo.Exam([Name],UpdateDate) values(@Name,getdate())
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
	ROLLBACK TRANSACTION
	SELECT 
	ERROR_NUMBER() AS ErrorNumber ,
	ERROR_SEVERITY() As ErrorSeverity,
	ERROR_STATE() AS ErrorState,
	 ERROR_PROCEDURE() AS ErrorProcesure,
	 ERROR_LINE() AS ErroLine,
	 ERROR_MESSAGE() AS ErrorMessage
	END CATCH
	 
END
GO
/****** Object:  StoredProcedure [dbo].[uspInsertUserAnswer]    Script Date: 5/14/2018 10:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[uspInsertUserAnswer]
(
@userid int ,
@questionid int ,
@choiceid int,
@exampaperid int ,
@USERANSWERID int out
)
AS
BEGIN
SET NOCOUNT ON ;
SET XACT_ABORT ON;
BEGIN TRY
	BEGIN TRAN
	
	insert into UserAnswer(UserID,QuestionId, ChoiceID,ExamPaperID) values(@userid,@questionid,@choiceid,@exampaperid)
	SET @USERANSWERID=scope_identity();
	commit tran


END TRY

BEGIN CATCH
IF @@TRANCOUNT>0
		ROLLBACK TRAN ;--#3
	THROW;

END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[uspInsetQuestionWithAnswer]    Script Date: 5/14/2018 10:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspInsetQuestionWithAnswer]
(
@questiontype int,
@exampaperid int,
@questiontext varchar(max),
@chioce1 varchar(max),
@chioce2 varchar(max),
@chioce3 varchar(max),
@chioce4 varchar(max),
@answer varchar(max),
@QUESTIONID int out
)
As
BEGIN --#1
SET NOCOUNT ON ;
SET XACT_ABORT ON;
	BEGIN TRY --#2
		BEGIN TRAN --#3

	--DECLARE @QUESTIONID INT;
	DECLARE @CHOICEID INT;
	SET @CHOICEID=0;
	DECLARE @temperror varchar(max);
	INSERT INTO Question(QuestionText,QuestionTypeID,ExamPaperID,CreatedDate) 
	VALUES(@questiontext,@questiontype,@exampaperid,GETDATE())
	SET @QUESTIONID=scope_identity();
	
	print 'after declaration choice id ='  +convert(varchar(max),@CHOICEID);
	--print convert(varchar(max),@CHOICEID);
	--insert choice 1	
	insert into Choice(ChoiceText,QuestionID) values(@chioce1,@QUESTIONID);
	IF(@chioce1=@answer)
	SET	@CHOICEID=SCOPE_IDENTITY();
	
--set @temperror=	'after first iinsert choiceid= ' + @CHOICEID;
--print  @temperror
	print  '=tis is ch';
	---- insert choice 2
	insert into Choice(ChoiceText,QuestionID) values(@chioce2,@QUESTIONID);
	IF(@chioce2=@answer)
	SET	@CHOICEID=SCOPE_IDENTITY();

	--set @temperror=	'after second iinsert choiceid= ' + convert(varchar(max), @CHOICEID) 
--print convert(varchar(max), @temperror)  

	-- insert choice 3
	insert into Choice(ChoiceText,QuestionID) values(@chioce3,@QUESTIONID);
	IF(@chioce3=@answer)
	SET	@CHOICEID=SCOPE_IDENTITY();

	print 'after 3rd iinsert choiceid=' 
	-- insert choice 4
	insert into Choice(ChoiceText,QuestionID) values(@chioce4,@QUESTIONID);
	IF(@chioce4=@answer)
	SET	@CHOICEID=SCOPE_IDENTITY();

	print 'after 4th iinsert choiceid='

--select	 'choice id=' + @CHOICEID;

	-- insert Question's Answer
	if(@CHOICEID>0)
	BEGIN
	--select 'choice id in choice' + @CHOICEID;
	insert into Answer(QuestionID,ChoiceID) values(@QUESTIONID,@CHOICEID);
	
	COMMIT TRAN; --#3
	
END
	else
	BEGIN
	DECLARE @error_msg varchar(max);
	SET @error_msg='choice id not found';   
	print @error_msg;
	ROLLBACK TRAN;
	THROW 60000,@error_msg,1;
 	--RAISEERROR(@error_msg,16,1,1)
	--print 'error is thrown'
	
	END
	
	END TRY --#2
	BEGIN CATCH --#4
	print 'inside catch cnt' + convert(varchar(max), @@TRANCOUNT)
	IF @@TRANCOUNT>0
		ROLLBACK TRAN ;--#3
	THROW;
	--END--#5
	END CATCH --#4
	--SET XACT_ABORT OFF
	select @QUESTIONID 
END --#1
GO
/****** Object:  StoredProcedure [dbo].[uspUpdateUserAnswerById]    Script Date: 5/14/2018 10:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[uspUpdateUserAnswerById]
(
@useranswerid int,
@choiceid int= null
)
AS
BEGIN
SET NOCOUNT ON ;
SET XACT_ABORT ON;
BEGIN TRY
	BEGIN TRAN
	
	update UserAnswer set ChoiceID=@choiceid
	where ID=@useranswerid

	commit tran


END TRY

BEGIN CATCH
IF @@TRANCOUNT>0
		ROLLBACK TRAN ;--#3
	THROW;

END CATCH

END
GO
USE [master]
GO
ALTER DATABASE [OnlineExam] SET  READ_WRITE 
GO
