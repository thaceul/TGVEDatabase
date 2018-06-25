CREATE TABLE [dbo].[Tour]
(
	[TourID] INT NOT NULL PRIMARY KEY,
	[TourName] NChar(50) NOT NULL,
	[Description] NChar(300) NOT NULL

	CONSTRAINT [UniqueTourName] UNIQUE([TourName])
)
