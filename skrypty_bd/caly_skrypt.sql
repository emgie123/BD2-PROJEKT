
	--drop table ZalaczoneDokumenty, WyposazenieDodatkowe, DaneSamochodu, Klienci, ModeleSamochodow, MarkiSamochodow, Adres
	
CREATE TABLE [dbo].[Adres]
(
	[IdAdresu] int NOT NULL PRIMARY KEY IDENTITY ,
	[Miejscowosc] varchar(50) NOT NULL ,
	[KodPocztowy] varchar(6) NOT NULL ,
	[Ulica] varchar(50) NOT NULL ,


	)
	
	CREATE TABLE [dbo].[MarkiSamochodow]
(
	[IdMarki] int NOT NULL PRIMARY KEY IDENTITY,
	[Marka] varchar(50) NOT NULL 


	)
	
	CREATE TABLE [dbo].[ModeleSamochodow]
(
	[IdModelu] int NOT NULL PRIMARY KEY IDENTITY,
	[Model] varchar(50) NOT NULL ,
	[IdMarki] int FOREIGN KEY REFERENCES MarkiSamochodow(IdMarki) ON DELETE CASCADE ON UPDATE CASCADE,
	[TypPojazdu] varchar(50) NOT NULL

	)
	
	CREATE TABLE [dbo].[Klienci]
(
	[IdKlienta] int NOT NULL PRIMARY KEY IDENTITY,
	[Imie] VARCHAR(50) NOT NULL,
	[Nazwisko] VARCHAR(50) NOT NULL,
	[IdAdresu] int FOREIGN KEY REFERENCES Adres(IdAdresu) ON DELETE CASCADE ON UPDATE CASCADE,
	[Email] VARCHAR(50),
	[Telefon] VARCHAR(50) NOT NULL,
	[Pesel] VARCHAR(50) NOT NULL,
	[Nip] VARCHAR(50),
	[NrKonta] VARCHAR(50) NOT NULL,
	[TypKlienta] BIT NOT NULL,

	)

	CREATE TABLE [dbo].[DaneSamochodu]
(
	[IdSamochodu] INT NOT NULL PRIMARY KEY IDENTITY,
	[IdModelu] INT NOT NULL FOREIGN KEY REFERENCES ModeleSamochodow(IdModelu) ON DELETE CASCADE ON UPDATE CASCADE,
	[RokProdukcji] VARCHAR(4) NOT NULL ,
	[Przebieg] VARCHAR(8) NOT NULL,
	[Pojemnosc] VARCHAR(8) NOT NULL,
	[RodzajPaliwa] VARCHAR(20) NOT NULL,
	[SkrzyniaBiegow] VARCHAR(20) NOT NULL,
	[Bezwypadkowy] BIT NOT NULL,
	[DataPrzegladu] date NOT NULL,
	[DataUbezpieczenia] date NOT NULL,
	[DataPzyjecia] date NOT NULL,
	[Kolor] varchar(25) NOT NULL,
	[NrRejestracyjny] VARCHAR(10) NOT NULL,
	[IdKlienta] INT FOREIGN KEY REFERENCES Klienci(IdKlienta) ON DELETE CASCADE ON UPDATE CASCADE,
	[Cena] VARCHAR(50) NOT NULL,
	[LiczbaDrzwi] VARCHAR(2) NOT NULL,
	[RodzajNadwozia] VARCHAR(25) NOT NULL,
	[KrajPochodzenia] VARCHAR (25) NOT NULL,
	[Wyrozniony] Bit NOT NULL

	)

	
	CREATE TABLE [dbo].[WyposazenieDodatkowe]
(
	[IdSamochodu] INT FOREIGN KEY REFERENCES DaneSamochodu(IdSamochodu) ON DELETE CASCADE ON UPDATE CASCADE,
	[Abs]  BIT NOT NULL,
	[Esp] BIT NOT NULL,
	[Asr] BIT NOT NULL,
	[AirBag] BIT NOT NULL,
	[Wspomaganie] BIT NOT NULL,
	[Klimatyzacja] BIT NOT NULL,
	[ZapasoweOpony] BIT NOT NULL,

	
	)
	
	CREATE TABLE [dbo].[ZalaczoneDokumenty]
(
	[IdSamochodu] int FOREIGN KEY REFERENCES DaneSamochodu(IdSamochodu) ON DELETE CASCADE ON UPDATE CASCADE,
	[ZalaczonyDokument] varchar(50) NOT NULL ,

	)
	
