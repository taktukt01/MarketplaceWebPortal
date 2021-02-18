CREATE TABLE [dbo].[Product]
(
	[ProductID] INT NOT NULL, 
	[ModelID] INT NULL,
	[ManufactureID] INT NULL,
	[ProductImgUrl] NVARCHAR (250) NULL,
	[SubCategoryID] INT NULL,
	[ProductName] NVARCHAR (50) NULL,
	[PropertyID] INT NULL,
	PRIMARY KEY CLUSTERED ([ProductID] ASC),	
	CONSTRAINT [FK_dbo.Product_dbo.Property_PropertyID] FOREIGN KEY ([PropertyID]) 
        REFERENCES [dbo].[Property] ([PropertyID]) ON DELETE CASCADE
)
