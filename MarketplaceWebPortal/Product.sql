CREATE TABLE [dbo].[Product]
(
	[ProductID] INT NOT NULL, 
	[ModelID] INT NULL,
	[ManufacturerID] INT NULL,
	[ProductImgID] INT NULL,
	[SubCategoryID] INT NULL,
	[ProductName] NVARCHAR (50) NULL,
	PRIMARY KEY CLUSTERED ([ProductID] ASC),
	CONSTRAINT [FK_dbo.Product_dbo.Models_ModelID] FOREIGN KEY ([ModelID]) 
        REFERENCES [dbo].[Models] ([Model_ID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.Product_dbo.Manufactures_ManufacturerID] FOREIGN KEY ([ManufacturerID]) 
        REFERENCES [dbo].[Manufactures] ([ManufactureID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.Product_dbo.SubCategory_SubCategoryID] FOREIGN KEY ([SubCategoryID]) 
        REFERENCES [dbo].[SubCategory] ([SubCategoryID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.Product_dbo.ProductImage_ProductImgID] FOREIGN KEY ([ProductImgID]) 
        REFERENCES [dbo].[ProductImage] ([ProductImgID]) ON DELETE CASCADE
)
