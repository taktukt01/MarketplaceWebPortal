CREATE TABLE [dbo].[Application]
(
    [ApplicationID]  INT IDENTITY (1,1) NOT NULL,
	[ApplicationInOrOut] INT NULL,
	[MountingLocation]  NVARCHAR(50)  NULL,
	PRIMARY KEY CLUSTERED ([ApplicationID] ASC)
)
