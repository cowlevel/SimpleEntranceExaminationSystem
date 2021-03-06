USE [master]
GO
/****** Object:  Database [ExaminationSystemDb]    Script Date: 30/10/2020 1:32:41 pm ******/
CREATE DATABASE [ExaminationSystemDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExaminationSystemDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ExaminationSystemDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ExaminationSystemDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ExaminationSystemDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ExaminationSystemDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExaminationSystemDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExaminationSystemDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ExaminationSystemDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExaminationSystemDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExaminationSystemDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ExaminationSystemDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExaminationSystemDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ExaminationSystemDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ExaminationSystemDb] SET  MULTI_USER 
GO
ALTER DATABASE [ExaminationSystemDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExaminationSystemDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExaminationSystemDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExaminationSystemDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ExaminationSystemDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ExaminationSystemDb] SET QUERY_STORE = OFF
GO
USE [ExaminationSystemDb]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 30/10/2020 1:32:41 pm ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[ExamId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
	[ExaminationType] [int] NOT NULL,
	[ItemCount] [int] NOT NULL,
	[TimeLimit] [int] NOT NULL,
	[DateTimeAdded] [datetime] NULL,
	[Archived] [bit] NULL,
 CONSTRAINT [PK_dbo.Exam] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examinee]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examinee](
	[ExamineeId] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](60) NOT NULL,
	[FirstName] [nvarchar](60) NOT NULL,
	[MiddleName] [nvarchar](60) NULL,
	[Address] [nvarchar](150) NOT NULL,
	[City] [nvarchar](60) NOT NULL,
	[ContactNo] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](60) NOT NULL,
	[LastSchoolAttended] [nvarchar](150) NOT NULL,
	[YearGraduated] [int] NOT NULL,
	[ExamTakes] [int] NOT NULL,
	[DateTimeAdded] [datetime] NULL,
 CONSTRAINT [PK_dbo.Examinee] PRIMARY KEY CLUSTERED 
(
	[ExamineeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamineeAnswer]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamineeAnswer](
	[ExamineeAnswerId] [int] IDENTITY(1,1) NOT NULL,
	[ExamineeExamId] [int] NOT NULL,
	[QuestionId] [int] NOT NULL,
	[Answer] [nvarchar](150) NULL,
	[IsCorrect] [bit] NOT NULL,
	[DateTimeAnswered] [datetime] NULL,
 CONSTRAINT [PK_dbo.ExamineeAnswer] PRIMARY KEY CLUSTERED 
(
	[ExamineeAnswerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamineeExam]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamineeExam](
	[ExamineeExamId] [int] IDENTITY(1,1) NOT NULL,
	[ExamineeTakeId] [int] NOT NULL,
	[ExamId] [int] NOT NULL,
	[Score] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ExamineeExam] PRIMARY KEY CLUSTERED 
(
	[ExamineeExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamineeFailure]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamineeFailure](
	[ExamineeFailureId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[WaitDays] [int] NOT NULL,
	[DateTimeModified] [datetime] NULL,
 CONSTRAINT [PK_dbo.ExamineeFailure] PRIMARY KEY CLUSTERED 
(
	[ExamineeFailureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamineeTake]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamineeTake](
	[ExamineeTakeId] [int] IDENTITY(1,1) NOT NULL,
	[ExamineeId] [int] NOT NULL,
	[ExamCode] [nvarchar](8) NOT NULL,
	[UserId] [int] NOT NULL,
	[CodeDateTimeIssued] [datetime] NULL,
	[ExamDateTimeTaken] [datetime] NULL,
	[PassingRate] [int] NULL,
	[Result] [bit] NULL,
 CONSTRAINT [PK_dbo.ExamineeTake] PRIMARY KEY CLUSTERED 
(
	[ExamineeTakeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PassingRate]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassingRate](
	[PassingRateId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Rate] [int] NOT NULL,
	[DateTimeModified] [datetime] NULL,
 CONSTRAINT [PK_dbo.PassingRate] PRIMARY KEY CLUSTERED 
(
	[PassingRateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionBank]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionBank](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[ExamId] [int] NOT NULL,
	[QuestionNumber] [int] NOT NULL,
	[Question] [nvarchar](350) NULL,
	[CorrectAnswer] [nvarchar](200) NULL,
	[WrongAnswer1] [nvarchar](200) NULL,
	[WrongAnswer2] [nvarchar](200) NULL,
	[WrongAnswer3] [nvarchar](200) NULL,
 CONSTRAINT [PK_dbo.QuestionBank] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionBankHistory]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionBankHistory](
	[QuestionBankHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[QuestionNumber] [int] NOT NULL,
	[Question] [nvarchar](350) NULL,
	[CorrectAnswer] [nvarchar](200) NULL,
	[WrongAnswer1] [nvarchar](200) NULL,
	[WrongAnswer2] [nvarchar](200) NULL,
	[WrongAnswer3] [nvarchar](200) NULL,
	[UserId] [int] NULL,
	[DateTimeModified] [datetime] NULL,
 CONSTRAINT [PK_dbo.QuestionBankHistory] PRIMARY KEY CLUSTERED 
(
	[QuestionBankHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_dbo.Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemUser]    Script Date: 30/10/2020 1:32:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemUser](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](60) NOT NULL,
	[FirstName] [nvarchar](60) NOT NULL,
	[MiddleName] [nvarchar](60) NULL,
	[Username] [nvarchar](64) NOT NULL,
	[Pword] [nvarchar](250) NULL,
	[UserLevel] [nvarchar](20) NOT NULL,
	[AccountStatus] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.SystemUser] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_SubjectId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_SubjectId] ON [dbo].[Exam]
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[Exam]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExamineeExamId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_ExamineeExamId] ON [dbo].[ExamineeAnswer]
(
	[ExamineeExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_QuestionId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_QuestionId] ON [dbo].[ExamineeAnswer]
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExamId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_ExamId] ON [dbo].[ExamineeExam]
(
	[ExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExamineeTakeId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_ExamineeTakeId] ON [dbo].[ExamineeExam]
(
	[ExamineeTakeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[ExamineeFailure]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExamineeId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_ExamineeId] ON [dbo].[ExamineeTake]
(
	[ExamineeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[ExamineeTake]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[PassingRate]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExamId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_ExamId] ON [dbo].[QuestionBank]
(
	[ExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_QuestionId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_QuestionId] ON [dbo].[QuestionBankHistory]
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 30/10/2020 1:32:42 pm ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[QuestionBankHistory]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Exam_dbo.Subject_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([SubjectId])
GO
ALTER TABLE [dbo].[Exam] CHECK CONSTRAINT [FK_dbo.Exam_dbo.Subject_SubjectId]
GO
ALTER TABLE [dbo].[Exam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Exam_dbo.SystemUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[SystemUser] ([UserId])
GO
ALTER TABLE [dbo].[Exam] CHECK CONSTRAINT [FK_dbo.Exam_dbo.SystemUser_UserId]
GO
ALTER TABLE [dbo].[ExamineeAnswer]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamineeAnswer_dbo.ExamineeExam_ExamineeExamId] FOREIGN KEY([ExamineeExamId])
REFERENCES [dbo].[ExamineeExam] ([ExamineeExamId])
GO
ALTER TABLE [dbo].[ExamineeAnswer] CHECK CONSTRAINT [FK_dbo.ExamineeAnswer_dbo.ExamineeExam_ExamineeExamId]
GO
ALTER TABLE [dbo].[ExamineeAnswer]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamineeAnswer_dbo.QuestionBank_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[QuestionBank] ([QuestionId])
GO
ALTER TABLE [dbo].[ExamineeAnswer] CHECK CONSTRAINT [FK_dbo.ExamineeAnswer_dbo.QuestionBank_QuestionId]
GO
ALTER TABLE [dbo].[ExamineeExam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamineeExam_dbo.Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([ExamId])
GO
ALTER TABLE [dbo].[ExamineeExam] CHECK CONSTRAINT [FK_dbo.ExamineeExam_dbo.Exam_ExamId]
GO
ALTER TABLE [dbo].[ExamineeExam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamineeExam_dbo.ExamineeTake_ExamineeTakeId] FOREIGN KEY([ExamineeTakeId])
REFERENCES [dbo].[ExamineeTake] ([ExamineeTakeId])
GO
ALTER TABLE [dbo].[ExamineeExam] CHECK CONSTRAINT [FK_dbo.ExamineeExam_dbo.ExamineeTake_ExamineeTakeId]
GO
ALTER TABLE [dbo].[ExamineeFailure]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamineeFailure_dbo.SystemUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[SystemUser] ([UserId])
GO
ALTER TABLE [dbo].[ExamineeFailure] CHECK CONSTRAINT [FK_dbo.ExamineeFailure_dbo.SystemUser_UserId]
GO
ALTER TABLE [dbo].[ExamineeTake]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamineeTake_dbo.Examinee_ExamineeId] FOREIGN KEY([ExamineeId])
REFERENCES [dbo].[Examinee] ([ExamineeId])
GO
ALTER TABLE [dbo].[ExamineeTake] CHECK CONSTRAINT [FK_dbo.ExamineeTake_dbo.Examinee_ExamineeId]
GO
ALTER TABLE [dbo].[ExamineeTake]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamineeTake_dbo.SystemUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[SystemUser] ([UserId])
GO
ALTER TABLE [dbo].[ExamineeTake] CHECK CONSTRAINT [FK_dbo.ExamineeTake_dbo.SystemUser_UserId]
GO
ALTER TABLE [dbo].[PassingRate]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PassingRate_dbo.SystemUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[SystemUser] ([UserId])
GO
ALTER TABLE [dbo].[PassingRate] CHECK CONSTRAINT [FK_dbo.PassingRate_dbo.SystemUser_UserId]
GO
ALTER TABLE [dbo].[QuestionBank]  WITH CHECK ADD  CONSTRAINT [FK_dbo.QuestionBank_dbo.Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([ExamId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuestionBank] CHECK CONSTRAINT [FK_dbo.QuestionBank_dbo.Exam_ExamId]
GO
ALTER TABLE [dbo].[QuestionBankHistory]  WITH CHECK ADD  CONSTRAINT [FK_dbo.QuestionBankHistory_dbo.QuestionBank_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[QuestionBank] ([QuestionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuestionBankHistory] CHECK CONSTRAINT [FK_dbo.QuestionBankHistory_dbo.QuestionBank_QuestionId]
GO
ALTER TABLE [dbo].[QuestionBankHistory]  WITH CHECK ADD  CONSTRAINT [FK_dbo.QuestionBankHistory_dbo.SystemUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[SystemUser] ([UserId])
GO
ALTER TABLE [dbo].[QuestionBankHistory] CHECK CONSTRAINT [FK_dbo.QuestionBankHistory_dbo.SystemUser_UserId]
GO
USE [master]
GO
ALTER DATABASE [ExaminationSystemDb] SET  READ_WRITE 
GO
