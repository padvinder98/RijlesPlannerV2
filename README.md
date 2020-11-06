# RijlesPlannerV2
 
script voor Lesons table

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Description] [varchar](500) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lessons] ADD  DEFAULT (newid()) FOR [Id]
GO

