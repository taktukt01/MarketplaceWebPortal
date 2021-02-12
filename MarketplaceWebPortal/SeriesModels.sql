CREATE TABLE [dbo].[SeriesModels]
(
	[SeriesID] INT IDENTITY (1,1)  NOT NULL,
	[ModelID]  INT NULL,
	Primary Key Clustered ([SeriesID] ASC),
	CONSTRAINT [FK_dbo.SeriesModels_dbo.Models_ModelID] FOREIGN KEY ([ModelID]) 
	 REFERENCES [dbo].[Models] ([Model_ID]) ON DELETE CASCADE
)
