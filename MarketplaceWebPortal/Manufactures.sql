CREATE TABLE [dbo].[Manufactures]
(
	[ManufacturerID] INT IDENTITY(1,1) NOT NULL,
	[ManufactureName] NVARCHAR(50) NULL,
	PRIMARY KEY CLUSTERED ([ManufacturerID] ASC)
)
