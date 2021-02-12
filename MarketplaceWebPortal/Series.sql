CREATE TABLE [dbo].[Series]
(
	[SeriesID] INT IDENTITY (1,1) NOT NULL,
	[SeriesName]  CHAR(50) NULL,
	[SeriesInfo]   CHAR(250) NULL,
	PRIMARY KEY CLUSTERED ([SeriesID] ASC)
)
