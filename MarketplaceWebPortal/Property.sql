﻿CREATE TABLE [dbo].[Property]
(
    [PropertyID] INT   NOT NULL,
	[ApplicationID] INT  NULL,
	[air_flow] INT NOT NULL DEFAULT 5,
    [power_min] INT NOT NULL DEFAULT 1,
    [power_max] INT  NOT NULL DEFAULT 999,
    [operating_voltage_min] INT NOT NULL DEFAULT 1,
    [operating_voltage_max] INT NOT NULL DEFAULT 999,
    [fan_speed_min] INT NOT NULL DEFAULT 1,
    [fan_speed_max] INT NOT NULL DEFAULT 999,
    [number_of_fan_speed] INT NOT NULL DEFAULT 999,
    [sound_at_max_speed] INT NOT NULL DEFAULT 999,
    [height_min] INT NOT NULL DEFAULT 1,
    [height_max] INT NOT NULL DEFAULT 999,
    [weight] INT NOT NULL DEFAULT 1,
	[Accessories]  NVARCHAR (50)  NULL,

    PRIMARY KEY CLUSTERED ([PropertyID] ASC), 
	 CONSTRAINT [FK_dbo.Property_dbo.Application_ApplicationID] FOREIGN KEY ([ApplicationID]) 
	 REFERENCES [dbo].[Application] ([ApplicationID]) ON DELETE CASCADE, 

)
