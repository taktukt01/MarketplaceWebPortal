CREATE TABLE [dbo].[User]
(
	[UserID] INT IDENTITY(1,1) NOT NULL,
	[UserName] CHAR(50) NULL,
	[Password] NVARCHAR(300) NULL,
	[Email] NVARCHAR(300) NULL,
	[UserImgID] INT NULL,
	PRIMARY KEY CLUSTERED ([UserID] ASC),
	CONSTRAINT [FK_dbo.User_dbo.UserImage_UserImgID] FOREIGN KEY ([UserImgID])
	   REFERENCES [dbo].[UserImage] ([UserImgID]) ON DELETE CASCADE
)
