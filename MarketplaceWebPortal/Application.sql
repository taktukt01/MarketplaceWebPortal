CREATE TABLE [dbo].[Application]
(
    [ApplicationID]  INT  NOT NULL,
	[ApplicationName] NVARCHAR(50) NULL,
	[MountingLocation]  NVARCHAR(50)  NULL,
	PRIMARY KEY CLUSTERED ([ApplicationID] ASC)
)
