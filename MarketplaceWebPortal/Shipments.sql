CREATE TABLE [dbo].[Shipments]
(
	[ShipmentID] INT  NOT NULL,
	[OrderID] INT NOT NULL,
	[ShipmentDate] DATE NOT NULL,
	PRIMARY KEY CLUSTERED ([ShipmentID] ASC),
	CONSTRAINT [FK_dbo.Shipments_dbo.Orders_OrderID] FOREIGN KEY ([OrderID])
	     REFERENCES [dbo].[Orders] ([OrderID]) ON DELETE CASCADE
)
