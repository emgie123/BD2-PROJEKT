CREATE TABLE [dbo].[DaneSamochodu]
(
	[IdSamochodu] INT NOT NULL PRIMARY KEY IDENTITY,
	[IdModelu] INT NOT NULL FOREIGN KEY REFERENCES ModeleSamochodow(IdModelu) ON DELETE CASCADE ON UPDATE CASCADE,
	[RokProdukcji] INT NOT NULL ,
	[Przebieg] INT NOT NULL,
	[Pojemnosc] INT NOT NULL,
	[RodzajPaliwa] VARCHAR(10) NOT NULL,
	[SkrzyniaBiegow] VARCHAR(10) NOT NULL,
	[Bezwypadkowy] BIT NOT NULL,
	[DataPrzegladu] date NOT NULL,
	[DataUbezpieczenia] date NOT NULL,
	[DataPzyjecia] date NOT NULL,
	[Kolor] varchar(15) NOT NULL,
	[NrRejestracyjny] VARCHAR(7) NOT NULL,
	[IdKlienta] INT FOREIGN KEY REFERENCES Klienci(IdKlienta) ON DELETE CASCADE ON UPDATE CASCADE,
	[Cena] DECIMAL NOT NULL,
	[LiczbaDrzwi] INT NOT NULL,
	[RodzajNadwozia] VARCHAR(15) NOT NULL,
	[KrajPochodzenia] VARCHAR (15) NOT NULL
	)







