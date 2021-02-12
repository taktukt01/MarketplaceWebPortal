CREATE TABLE [dbo].[Property]
(
    [PropertyID] INT  IDENTITY (1,1) NOT NULL,
	[ApplicationID] INT  NULL,
	[ProductPropertyID] INT NULL,
	[FanSpeed]   INT   NULL,
	[SoundAtMaxSpeed]  INT  NULL,
	[NumberOfFanSpeed]  INT  NULL,
	[FanSweepDiameter]  INT  NULL,
	[Height]  INT   NULL,
	[OperatingVoltage]  INT  NULL,
	[Weight]  INT  NULL,
	[Accessories]  INT  NULL,
	PRIMARY KEY CLUSTERED ([PropertyID] ASC), 
	 CONSTRAINT [FK_dbo.Property_dbo.Application_ApplicationID] FOREIGN KEY ([ApplicationID]) 
	 REFERENCES [dbo].[Application] ([ApplicationID]) ON DELETE CASCADE,
	  CONSTRAINT [FK_dbo.Property_dbo.ProductProperty_ProductPropertyID] FOREIGN KEY ([ProductPropertyID]) 
	 REFERENCES [dbo].[ProductProperty] ([ProductPropertyID]) ON DELETE CASCADE
)
