﻿CREATE TABLE [dbo].[Event]
(
	[EventID] INT NOT NULL PRIMARY KEY,
	[EventDate] DATETIME NOT NULL,
	[Fees] MONEY NOT NULL,

	[TourID] INT NOT NULL,
	FOREIGN KEY ([TourID]) REFERENCES [Tour]([TourID])
)
