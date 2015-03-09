CREATE TABLE [dbo].[dane_samochodu]
(
	[Id_samochodu] INT NOT NULL PRIMARY KEY IDENTITY,
	[id_modelu] INT NOT NULL FOREIGN KEY REFERENCES modele_samochodow(id_modelu) ON DELETE CASCADE ON UPDATE CASCADE,
	[rok_produkcji] INT NOT NULL ,
	[przebieg] INT NOT NULL,
	[pojemnosc] INT NOT NULL,
	[rodzaj_paliwa] VARCHAR(10) NOT NULL,
	[skrzynia_biegow] VARCHAR(10) NOT NULL,
	[bezwypadkowy] BIT NOT NULL,
	[data_przegladu] date NOT NULL,
	[data_ubezpieczenia] date NOT NULL,
	[data_przyjecia] date NOT NULL,
	[kolor] varchar(15) NOT NULL,
	[nr_rejestracyjny] VARCHAR(7) NOT NULL,
	[id_klienta] INT FOREIGN KEY REFERENCES klienci(id_klienta) ON DELETE CASCADE ON UPDATE CASCADE,
	[cena] DECIMAL NOT NULL,
	[liczba_drzwi] INT NOT NULL,
	[rodzaj_nadwozia] VARCHAR(15) NOT NULL,
	[kraj_pochodzenia] VARCHAR (15) NOT NULL
	)







