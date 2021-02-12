CREATE TABLE [dbo].[Category]
(
	[CategoryID] INT IDENTITY(1,1) NOT NULL,
	[CategoryName]  CHAR(200) NULL,
	PRIMARY KEY CLUSTERED ([CategoryID] ASC)
)
