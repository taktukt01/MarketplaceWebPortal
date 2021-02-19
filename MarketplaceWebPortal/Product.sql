CREATE TABLE [dbo].[Product]
(
	[ProductID] INT NOT NULL, 
	[ModelID] INT NULL,
	[ManufactureID] INT NULL,
	[SeriesID] INT NULL,
	[ProductImgUrl] NVARCHAR (250) NULL,
	[SubCategoryID] INT NULL,
	[ProductName] NVARCHAR (50) NULL,
	[PropertyID] INT NULL,
	PRIMARY KEY CLUSTERED ([ProductID] ASC),	
    CONSTRAINT [FK_dbo.Product_dbo.Subcategory_SubcategoryID] FOREIGN KEY ([SubcategoryID]) REFERENCES [SubCategory]([SubcategoryID]), 
    CONSTRAINT [FK_dbo.Product_dbo.Manufactures_ManufactureID] FOREIGN KEY ([ManufactureID]) REFERENCES [Manufactures]([ManufactureID]),
	CONSTRAINT [FK_dbo.Product_dbo.Series_SeriesID] FOREIGN KEY ([SeriesID]) REFERENCES [Series]([SeriesID]),
    CONSTRAINT [FK_dbo.Product_dbo.Models_ModelID] FOREIGN KEY ([ModelID]) REFERENCES [Models]([Model_ID]), 
	CONSTRAINT [FK_dbo.Product_dbo.Property_PropertyID] FOREIGN KEY ([PropertyID]) REFERENCES [Property]([PropertyID]), 
)
