CREATE TABLE [dbo].[ModeleSamochodow]
(
	[IdModelu] int NOT NULL PRIMARY KEY IDENTITY,
	[Model] varchar(50) NOT NULL ,
	[IdMarki] int FOREIGN KEY REFERENCES MarkiSamochodow(IdMarki) ON DELETE CASCADE ON UPDATE CASCADE

	)