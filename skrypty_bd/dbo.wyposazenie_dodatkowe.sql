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