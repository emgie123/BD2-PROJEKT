CREATE TABLE [dbo].[ZalaczoneDokumenty]
(
	[IdSamochodu] int FOREIGN KEY REFERENCES DaneSamochodu(IdSamochodu) ON DELETE CASCADE ON UPDATE CASCADE,
	[ZalaczonyDokument] varchar(50) NOT NULL ,

	)