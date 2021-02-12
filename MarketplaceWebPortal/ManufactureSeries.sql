CREATE TABLE [dbo].[ManufactureSeries]
(
	[m_s_id] INT NOT NULL,
	[ManufactureID] INT NOT NULL,
	[SeriesID] INT NULL, 
	PRIMARY KEY CLUSTERED ([m_s_id] ASC),
	CONSTRAINT [FK_dbo.ManufactureSeries_dbo.Series_CourseID] FOREIGN KEY ([SeriesID]) 
        REFERENCES [dbo].[Series] ([SeriesID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.ManufactureSeries_dbo.Manufactures_ManufactureID] FOREIGN KEY ([ManufactureID]) 
        REFERENCES [dbo].[Manufactures] ([ManufactureID]) ON DELETE CASCADE
)
