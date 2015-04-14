CREATE TABLE [dbo].[Adres]
(
	[IdAdresu] int NOT NULL PRIMARY KEY IDENTITY ,
	[Miejscowosc] varchar(50) NOT NULL ,
	[KodPocztowy] varchar(6) NOT NULL ,
	[Ulica] varchar(50) NOT NULL ,


	)