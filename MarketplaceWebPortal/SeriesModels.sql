CREATE TABLE [dbo].[SeriesModels]
(
	[s_m_id] INT NOT NULL,
	[SeriesID] INT NOT NULL,
	[ModelID]  INT NULL,
	Primary Key Clustered ([s_m_id] ASC),
	CONSTRAINT [FK_dbo.SeriesModels_dbo.Models_ModelID] FOREIGN KEY ([ModelID]) 
	 REFERENCES [dbo].[Models] ([Model_ID]) ON DELETE CASCADE,
	 CONSTRAINT [FK_dbo.SeriesModels_dbo.Series_SiriesID] FOREIGN KEY ([SeriesID]) 
	 REFERENCES [dbo].[Series] ([SeriesID]) ON DELETE CASCADE
)
