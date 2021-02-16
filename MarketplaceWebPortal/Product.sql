CREATE TABLE [dbo].[Product]
(
	[ProductID] INT NOT NULL, 
	[ModelID] INT NULL,
	[ManufacturerID] INT NULL,
	[ProductImgUrl] NVARCHAR (250) NULL,
	[SubCategoryID] INT NULL,
	[ProductName] NVARCHAR (50) NULL,
	PRIMARY KEY CLUSTERED ([ProductID] ASC),	
)
