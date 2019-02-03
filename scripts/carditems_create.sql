USE [Gaia]
GO

/****** Object:  Table [dbo].[TodoItems]    Script Date: 03/02/2019 20:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CardItems](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Category] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[Rarity] [int] NOT NULL,
	[Level] [int] NOT NULL,
	[ManaCost] [int] NOT NULL,
	[LifeCost] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
