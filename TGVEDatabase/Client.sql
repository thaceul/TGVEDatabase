CREATE TABLE [dbo].[Client]
(
	[ClientID] INT NOT NULL PRIMARY KEY,
	[FirstName] NChar(50) NULL,
	[LastName] NCHar(50)  NOT NULL,
	[Gender] Char(1) NULL

	CONSTRAINT [GenderMorF] CHECK ([Gender] IN('M','F'))	
)
