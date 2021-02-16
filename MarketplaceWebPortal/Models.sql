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
    
)
