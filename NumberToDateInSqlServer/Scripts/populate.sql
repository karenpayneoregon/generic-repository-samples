/*
	Create Examples database under SQLEXPRESS and if not to the server of your choice and
	change the server name in the connection string in the C# code.
*/

USE [Examples]
CREATE TABLE [dbo].[ChallengeTable](
	[Id] [INT] IDENTITY(1,1) NOT NULL,
	[DateValue] [INT] NULL,
 CONSTRAINT [PK_ChallengeTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChallengeTable] ON 

INSERT [dbo].[ChallengeTable] ([Id], [DateValue]) VALUES (1, 20240101)
INSERT [dbo].[ChallengeTable] ([Id], [DateValue]) VALUES (2, 20240102)
INSERT [dbo].[ChallengeTable] ([Id], [DateValue]) VALUES (3, 20240103)
INSERT [dbo].[ChallengeTable] ([Id], [DateValue]) VALUES (4, 20240104)
INSERT [dbo].[ChallengeTable] ([Id], [DateValue]) VALUES (5, 20240105)
SET IDENTITY_INSERT [dbo].[ChallengeTable] OFF
GO
