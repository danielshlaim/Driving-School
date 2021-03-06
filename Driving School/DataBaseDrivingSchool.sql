USE [Driving School]
GO
/****** Object:  Table [dbo].[Drive_Courses]    Script Date: 26/02/2022 23:27:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drive_Courses](
	[Courses_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Number_Of_Lessones] [int] NOT NULL,
	[Rank] [nchar](10) NOT NULL,
	[Driving_instructor_Id] [int] NOT NULL,
	[History_Id] [int] NULL,
 CONSTRAINT [PK_Drive_Courses] PRIMARY KEY CLUSTERED 
(
	[Courses_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Driving_instructors]    Script Date: 26/02/2022 23:27:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Driving_instructors](
	[Driving_instructors_Id] [int] IDENTITY(1,1) NOT NULL,
	[Driving_instructor_IdentityNumber] [int] NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Phone_Number] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Courses_Id] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Driving_instructors] PRIMARY KEY CLUSTERED 
(
	[Driving_instructors_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 26/02/2022 23:27:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[History_Id] [int] IDENTITY(1,1) NOT NULL,
	[Driving_instructor_Id] [int] NOT NULL,
	[Student_Id] [int] NOT NULL,
	[Courses_Id] [int] NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[History_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 26/02/2022 23:27:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Student_Id] [int] IDENTITY(1,1) NOT NULL,
	[Student_IdentityNumber] [int] NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Phone_Number] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Courses_Id] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Students_1] PRIMARY KEY CLUSTERED 
(
	[Student_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Drive_Courses] ON 

INSERT [dbo].[Drive_Courses] ([Courses_Id], [Name], [Number_Of_Lessones], [Rank], [Driving_instructor_Id], [History_Id]) VALUES (1, N'Car', 28, N'B         ', 315763995, 5)
INSERT [dbo].[Drive_Courses] ([Courses_Id], [Name], [Number_Of_Lessones], [Rank], [Driving_instructor_Id], [History_Id]) VALUES (2, N'MotorCycle', 20, N'A         ', 379546278, 6)
INSERT [dbo].[Drive_Courses] ([Courses_Id], [Name], [Number_Of_Lessones], [Rank], [Driving_instructor_Id], [History_Id]) VALUES (3, N'Taxi', 30, N'P         ', 452796115, NULL)
SET IDENTITY_INSERT [dbo].[Drive_Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Driving_instructors] ON 

INSERT [dbo].[Driving_instructors] ([Driving_instructors_Id], [Driving_instructor_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (1, 315763995, N'Jesson', N'Mesh', 501297652, N'Jesson@gmail.com', 1, N'jess', N'31576')
INSERT [dbo].[Driving_instructors] ([Driving_instructors_Id], [Driving_instructor_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (2, 379546278, N'Mike', N'Ness', 543997445, N'Mike@gmail.com', 2, N'mike', N'37954')
INSERT [dbo].[Driving_instructors] ([Driving_instructors_Id], [Driving_instructor_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (3, 452796115, N'Amir', N'Ash', 586318874, N'Amir@gmail.com', 3, N'ami', N'45279')
SET IDENTITY_INSERT [dbo].[Driving_instructors] OFF
GO
SET IDENTITY_INSERT [dbo].[History] ON 

INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (5, 315763995, 138664778, 1)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (6, 16516, 56156, 2)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (7, 315763995, 1, 1)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (8, 315763995, 1, 1)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (9, 315763995, 1, 1)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (10, 379546278, 1, 2)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (1007, 452796115, 2, 3)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (1008, 452796115, 2, 3)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (1009, 452796115, 1, 3)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (1010, 379546278, 1, 2)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (1011, 452796115, 2, 3)
INSERT [dbo].[History] ([History_Id], [Driving_instructor_Id], [Student_Id], [Courses_Id]) VALUES (1012, 315763995, 2, 1)
SET IDENTITY_INSERT [dbo].[History] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Student_Id], [Student_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (1, 151545454, N'Or', N'Agever', 506951678, N'ortheog@gmail.com', 0, N'orshani1', N'or1232')
INSERT [dbo].[Students] ([Student_Id], [Student_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (2, 138664778, N'Daiv', N'Deness', 59617532, N'Daiv@gmail.com', 1, N'div123', N'13866')
INSERT [dbo].[Students] ([Student_Id], [Student_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (3, 315257895, N'Mishell', N'Muhana', 503918652, N'Mish@gmail.com', 0, N'mish', N'31525')
INSERT [dbo].[Students] ([Student_Id], [Student_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (4, 332415889, N'Avichii', N'Dah', 529741556, N'Avichii@gmail.com', 2, N'avi', N'33241')
INSERT [dbo].[Students] ([Student_Id], [Student_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (5, 553145248, N'Vova', N'Gess', 556415578, N'vova@gmail.com', 3, N'vov', N'55314')
INSERT [dbo].[Students] ([Student_Id], [Student_IdentityNumber], [First_Name], [Last_Name], [Phone_Number], [Email], [Courses_Id], [UserName], [Password]) VALUES (6, 998855314, N'Dan', N'Shel', 50348617, N'Dan@gmail.com', 2, N'dan', N'99885')
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
ALTER TABLE [dbo].[Drive_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Drive_Courses_History] FOREIGN KEY([History_Id])
REFERENCES [dbo].[History] ([History_Id])
GO
ALTER TABLE [dbo].[Drive_Courses] CHECK CONSTRAINT [FK_Drive_Courses_History]
GO
ALTER TABLE [dbo].[Drive_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Drive_Courses_Students] FOREIGN KEY([Courses_Id])
REFERENCES [dbo].[Students] ([Student_Id])
GO
ALTER TABLE [dbo].[Drive_Courses] CHECK CONSTRAINT [FK_Drive_Courses_Students]
GO
ALTER TABLE [dbo].[Driving_instructors]  WITH CHECK ADD  CONSTRAINT [FK_Driving_instructors_Drive_Courses] FOREIGN KEY([Courses_Id])
REFERENCES [dbo].[Drive_Courses] ([Courses_Id])
GO
ALTER TABLE [dbo].[Driving_instructors] CHECK CONSTRAINT [FK_Driving_instructors_Drive_Courses]
GO
ALTER TABLE [dbo].[Driving_instructors]  WITH CHECK ADD  CONSTRAINT [FK_Driving_instructors_Students] FOREIGN KEY([Driving_instructors_Id])
REFERENCES [dbo].[Students] ([Student_Id])
GO
ALTER TABLE [dbo].[Driving_instructors] CHECK CONSTRAINT [FK_Driving_instructors_Students]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Drive_Courses] FOREIGN KEY([Courses_Id])
REFERENCES [dbo].[Drive_Courses] ([Courses_Id])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Drive_Courses]
GO
