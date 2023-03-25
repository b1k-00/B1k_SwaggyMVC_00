USE [1K]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 3/25/2023 2:46:46 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO


