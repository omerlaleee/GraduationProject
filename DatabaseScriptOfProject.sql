USE [GraduationProjectDB]
GO
/****** Object:  Table [dbo].[BuildReporters]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuildReporters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[DetailedAddress] [nvarchar](max) NOT NULL,
	[Urgency] [nvarchar](max) NOT NULL,
	[MapsAddress] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_BuildReporters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColdVictims]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColdVictims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VictimId] [int] NOT NULL,
 CONSTRAINT [PK_ColdVictims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DebrisVictims]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DebrisVictims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VictimId] [int] NOT NULL,
 CONSTRAINT [PK_DebrisVictims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodHelpers]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodHelpers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HelperId] [int] NOT NULL,
	[InfoAboutHelp] [nvarchar](max) NOT NULL,
	[NumberOfPeople] [int] NOT NULL,
	[MapsAddress] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_FoodHelpers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodVictims]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodVictims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VictimId] [int] NOT NULL,
 CONSTRAINT [PK_FoodVictims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Helpers]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Helpers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Helpers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HouseHelpers]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HouseHelpers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HelperId] [int] NOT NULL,
	[InfoAboutHelp] [nvarchar](max) NOT NULL,
	[NumberOfPeople] [int] NOT NULL,
	[MapsAddress] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_HouseHelpers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperatorHelpers]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperatorHelpers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HelperId] [int] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[InfoAboutHelp] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_OperatorHelpers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TentHelpers]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TentHelpers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HelperId] [int] NOT NULL,
	[InfoAboutHelp] [nvarchar](max) NOT NULL,
	[NumberOfPeople] [int] NOT NULL,
	[MapsAddress] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TentHelpers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransporterHelpers]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransporterHelpers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HelperId] [int] NOT NULL,
	[InfoAboutHelp] [nvarchar](max) NOT NULL,
	[AddressFrom] [nvarchar](max) NOT NULL,
	[AddressTo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TransporterHelpers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Victims]    Script Date: 01/04/2023 18:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Victims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[NumberOfPeople] [int] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[DetailedAddress] [nvarchar](max) NOT NULL,
	[Urgency] [nvarchar](max) NOT NULL,
	[StatusInformation] [nvarchar](max) NOT NULL,
	[MapsAddress] [nvarchar](max) NOT NULL,
	[VictimType] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Victims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ColdVictims]  WITH CHECK ADD  CONSTRAINT [FK_ColdVictims_Victims] FOREIGN KEY([VictimId])
REFERENCES [dbo].[Victims] ([Id])
GO
ALTER TABLE [dbo].[ColdVictims] CHECK CONSTRAINT [FK_ColdVictims_Victims]
GO
ALTER TABLE [dbo].[DebrisVictims]  WITH CHECK ADD  CONSTRAINT [FK_DebrisVictims_Victims] FOREIGN KEY([VictimId])
REFERENCES [dbo].[Victims] ([Id])
GO
ALTER TABLE [dbo].[DebrisVictims] CHECK CONSTRAINT [FK_DebrisVictims_Victims]
GO
ALTER TABLE [dbo].[FoodHelpers]  WITH CHECK ADD  CONSTRAINT [FK_FoodHelpers_Helpers] FOREIGN KEY([HelperId])
REFERENCES [dbo].[Helpers] ([Id])
GO
ALTER TABLE [dbo].[FoodHelpers] CHECK CONSTRAINT [FK_FoodHelpers_Helpers]
GO
ALTER TABLE [dbo].[FoodVictims]  WITH CHECK ADD  CONSTRAINT [FK_FoodVictims_Victims] FOREIGN KEY([VictimId])
REFERENCES [dbo].[Victims] ([Id])
GO
ALTER TABLE [dbo].[FoodVictims] CHECK CONSTRAINT [FK_FoodVictims_Victims]
GO
ALTER TABLE [dbo].[HouseHelpers]  WITH CHECK ADD  CONSTRAINT [FK_HouseHelpers_Helpers] FOREIGN KEY([HelperId])
REFERENCES [dbo].[Helpers] ([Id])
GO
ALTER TABLE [dbo].[HouseHelpers] CHECK CONSTRAINT [FK_HouseHelpers_Helpers]
GO
ALTER TABLE [dbo].[OperatorHelpers]  WITH CHECK ADD  CONSTRAINT [FK_OperatorHelpers_Helpers] FOREIGN KEY([HelperId])
REFERENCES [dbo].[Helpers] ([Id])
GO
ALTER TABLE [dbo].[OperatorHelpers] CHECK CONSTRAINT [FK_OperatorHelpers_Helpers]
GO
ALTER TABLE [dbo].[TentHelpers]  WITH CHECK ADD  CONSTRAINT [FK_TentHelpers_Helpers] FOREIGN KEY([HelperId])
REFERENCES [dbo].[Helpers] ([Id])
GO
ALTER TABLE [dbo].[TentHelpers] CHECK CONSTRAINT [FK_TentHelpers_Helpers]
GO
ALTER TABLE [dbo].[TransporterHelpers]  WITH CHECK ADD  CONSTRAINT [FK_TransporterHelpers_Helpers] FOREIGN KEY([HelperId])
REFERENCES [dbo].[Helpers] ([Id])
GO
ALTER TABLE [dbo].[TransporterHelpers] CHECK CONSTRAINT [FK_TransporterHelpers_Helpers]
GO
