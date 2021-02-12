CREATE TABLE [dbo].[Models]
(
	[Model_id] INT NOT NULL,
    [model_name] NVARCHAR(50) NULL,
    [model_year]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Model_id] ASC),
    [use_type] NVARCHAR(50) NULL,
    [application] NVARCHAR(50) NULL,
    [mounting_location] NVARCHAR(50) NULL,
    [accessories] NVARCHAR(50) NULL,
    [air_flow] INT NOT NULL DEFAULT 5,
    [power_min] DECIMAL (4,2) NOT NULL DEFAULT 1,
    [power_max] DECIMAL (4,2) NOT NULL DEFAULT 999,
    [operating_voltage_min] INT NOT NULL DEFAULT 1,
    [operating_voltage_max] INT NOT NULL DEFAULT 999,
    [fan_speed_min] INT NOT NULL DEFAULT 1,
    [fan_speed_max] INT NOT NULL DEFAULT 999,
    [number_of_fan_speed] INT NOT NULL DEFAULT 999,
    [sound_at_max_speed] INT NOT NULL DEFAULT 999,
    [height_min] DECIMAL NOT NULL DEFAULT 1,
    [height_max] DECIMAL NOT NULL DEFAULT 999,
    [weight] DECIMAL NOT NULL DEFAULT 1
)
