CREATE TABLE [dbo].[ManufactureSeries]
(
	[ManufactureID] INT IDENTITY (1,1) NOT NULL,
	[SeriesID] INT NULL, 
	PRIMARY KEY CLUSTERED ([ManufactureID] ASC),
	CONSTRAINT [FK_dbo.ManufactureSeries_dbo.Series_CourseID] FOREIGN KEY ([SeriesID]) 
        REFERENCES [dbo].[Series] ([SeriesID]) ON DELETE CASCADE
)
