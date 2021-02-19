CREATE TABLE [dbo].[SubCategory]
(
	[SubCategoryID] INT  NOT NULL,
	[CategoryID] INT NULL,
	[SubCategoryName] NVARCHAR (50) NULL,
	PRIMARY KEY CLUSTERED ([SubCategoryID] ASC),
	CONSTRAINT [FK_dbo.SubCategory_dbo.Category_CategoryID] FOREIGN KEY ([CategoryID])
	     REFERENCES [dbo].[Category] ([CategoryID]),
)
