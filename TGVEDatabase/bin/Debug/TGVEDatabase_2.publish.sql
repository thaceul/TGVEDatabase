﻿/*
Deployment script for SwdTGVEDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar LoadSampleData "true"
:setvar DatabaseName "SwdTGVEDB"
:setvar DefaultFilePrefix "SwdTGVEDB"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
PRINT N'Dropping [dbo].[GenderMorF]...';


GO
ALTER TABLE [dbo].[Client] DROP CONSTRAINT [GenderMorF];


GO
PRINT N'Creating [dbo].[GenderMorF]...';


GO
ALTER TABLE [dbo].[Client] WITH NOCHECK
    ADD CONSTRAINT [GenderMorF] CHECK ([Gender] IN('M','F'));


GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF '$(LoadSampleData)' = 'true'
BEGIN

DELETE [Booking];
DELETE [Event];
DELETE [Tour];
DELETE [Client];

INSERT INTO [Client] ([ClientID],FirstName,LastName,[Gender]) VALUES
(1,'Taylor','Price','M'),
(2,'Ellyse','Gamble','F'),
(3,'Tilly','Tan','F')

SET IDENTITY_INSERT [Tour] ON;
INSERT INTO [Tour] ([TourID],[TourName],[Description]) VALUES
(1,'West','Tour of wineries and outlets of the Geelong and Otways region'),
(2,'East','Tour of wineries and outlets of the Yarra Valley'),
(3,'South','Tour of wineries and outlets of Mornington Penisula'),
(4,'North','Tour of wineries and outlets of the Bedigo and Castlemaine region')
SET IDENTITY_INSERT [Tour] OFF;

SET IDENTITY_INSERT [Event] ON;
INSERT INTO [Event] ([EventID],[TourID],[EventDate],[fee]) VALUES
(1,4,'2016-01-09',200),
(2,4,'2016-02-13',225),
(3,3,'2016-01-16',200),
(4,1,'2016-01-29',225)
SET IDENTITY_INSERT [Event] OFF;

INSERT INTO [Booking] ([ClientID],[EventID],[Payment],[DateBooked]) VALUES
(1,1,200,'2015-12-10'),
(2,1,200,'2015-12-16'),
(1,2,225,'2016-01-08'),
(2,2,225,'2016-01-14'),
(3,2,225,'2016-02-03'),
(1,3,200,'2015-12-10'),
(2,3,200,'2015-12-18'),
(3,3,200,'2016-01-09'),
(2,4,200,'2015-12-17'),
(3,4,200,'2015-12-18')

END
GO

GO
