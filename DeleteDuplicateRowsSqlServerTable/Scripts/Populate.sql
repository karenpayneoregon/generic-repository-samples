USE [Examples]
GO
/****** Object:  Table [dbo].[PersonWithDuplicates]    Script Date: 1/22/2024 7:10:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonWithDuplicates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[BirthDay] [date] NULL,
 CONSTRAINT [PK_PersonWithDuplicates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PersonWithDuplicates] ON 

INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (1, N'Bill', N'Smith', CAST(N'1976-09-01' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (2, N'Mary', N'Robinson', CAST(N'1945-12-12' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (3, N'Bill', N'Smith', CAST(N'1976-09-01' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (4, N'Bill', N'Smith', CAST(N'1976-09-01' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (5, N'Nancy', N'Jones', CAST(N'2000-02-23' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (6, N'Nancy', N'Johnson', CAST(N'2005-08-12' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (7, N'Nancy', N'Jones', CAST(N'2000-02-23' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (8, N'Karen', N'Payne', CAST(N'1956-09-09' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (9, N'Kim', N'Adams', CAST(N'1989-07-12' AS Date))
INSERT [dbo].[PersonWithDuplicates] ([Id], [FirstName], [LastName], [BirthDay]) VALUES (10, N'Karen', N'Payne', CAST(N'1956-09-09' AS Date))
SET IDENTITY_INSERT [dbo].[PersonWithDuplicates] OFF
GO
