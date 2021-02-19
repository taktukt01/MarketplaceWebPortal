CREATE TABLE [dbo].[Orders]
(
	[OrderID] INT  NOT NULL,
	[UserID] INT NOT NULL,
	[OrderDate] Date NOT NULL,
	PRIMARY KEY CLUSTERED ([OrderID] ASC),
	CONSTRAINT [FK_dbo.Orders_dbo.User_UserID] FOREIGN KEY ([UserID])
	REFERENCES [dbo].[User] ([UserID]) ON DELETE CASCADE
)
