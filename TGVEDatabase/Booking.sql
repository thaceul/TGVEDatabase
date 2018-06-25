CREATE TABLE [dbo].[Booking]
(
	[Payment] MONEY NOT NULL,
	[DateBooked] DATETIME NULL,

	[ClientID] INT NOT NULL,
	FOREIGN KEY ([ClientID]) REFERENCES [Client]([ClientID]),

	[EventID] INT NOT NULL,
	FOREIGN KEY ([EventID]) REFERENCES [Event]([EventID]),

	PRIMARY KEY ([ClientID],[EventID]),
)
