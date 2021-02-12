CREATE TABLE [dbo].[ProductImage]
(
	[ProductImgID] INT IDENTITY(1,1) NOT NULL,
	[ProductImgTitle] CHAR(50) NULL,
	[ProductImgUrl] CHAR(300) NULL,
	PRIMARY KEY CLUSTERED ([ProductImgID] ASC)
)
