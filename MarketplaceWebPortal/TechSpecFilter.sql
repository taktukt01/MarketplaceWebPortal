CREATE TABLE [dbo].[TechSpecFilter]
(
    [TechSpecID]  INT  NOT NULL,
	[PropertyID] INT NULL, 
	[SubCategoryID] INT NULL, 
	[MaxVal]  INT NULL,
	[MinVal]  INT NULL,
	PRIMARY KEY CLUSTERED ([TechSpecID] ASC),
	CONSTRAINT [FK_dbo.TechSpecFilter_dbo.Property_PropertyID] FOREIGN KEY ([PropertyID]) 
        REFERENCES [dbo].[Property] ([PropertyID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.TechSpecFilter_dbo.SubCategory_SubCategoryID] FOREIGN KEY ([SubCategoryID]) 
        REFERENCES [dbo].[SubCategory] ([SubCategoryID]) ON DELETE CASCADE
)
