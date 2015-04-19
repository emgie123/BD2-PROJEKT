--DBCC CHECKIDENT ('[TestTable]', RESEED, 0) 

insert into Adres values ('Opole','43-433','Wiejska 45/3')
insert into Adres values ('Opole','42-434','Opolska 4/2')
insert into Adres values ('Głubczyce','42-413','Krakowska 1/53')
insert into Adres values ('Wrocław','12-321','Mickiewicza 32')
insert into Adres values ('Czarnowąsy','12-623','Wąska 9')


insert into Klienci values('Janusz','Kowalski',1,'janusz@kowalski.pl','123-432-321','94933443','','434333234',1)
insert into Klienci values('Andrzej','Nowak',2,'andrzej@nowak.com','143-431-232','43223432','','431198766',1)
insert into Klienci values('Martyna','Biała',3,'m@wojciech.pl','433-969-443','8778787','','98978788',1)
insert into Klienci values('Artur','Borubar',4,'artur@borubar.pl','143-885-332','4356464','','09390383',1)
insert into Klienci values('Anna','Długa',5,'a@d.pl','434-111-222','5434564','','773323',1)


insert into MarkiSamochodow values('Volkswagen')
insert into MarkiSamochodow values('Opel')
insert into MarkiSamochodow values('Audi')
insert into MarkiSamochodow values('Honda')
insert into MarkiSamochodow values('Toyota')
insert into MarkiSamochodow values('Hyundai')
insert into MarkiSamochodow values('Chrysler')
insert into MarkiSamochodow values('KIA')
insert into MarkiSamochodow values('Ford')
insert into MarkiSamochodow values('Jeep')
insert into MarkiSamochodow values('Bugatti')
insert into MarkiSamochodow values('Ferrari')
insert into MarkiSamochodow values('Porsche')
insert into MarkiSamochodow values('Lamborghini')
insert into MarkiSamochodow values('Dodge')
insert into MarkiSamochodow values('Nissan')
insert into MarkiSamochodow values('Mitsubishi')
insert into MarkiSamochodow values('Aston-Martin')
insert into MarkiSamochodow values('Alfa-Romeo')
insert into MarkiSamochodow values('Bentley')
insert into MarkiSamochodow values('Citroen')
insert into MarkiSamochodow values('Dacia')
insert into MarkiSamochodow values('Fiat')
insert into MarkiSamochodow values('Lancia')
insert into MarkiSamochodow values('Maseratti')
insert into MarkiSamochodow values('Peugeot')
insert into MarkiSamochodow values('Mercedes')
insert into MarkiSamochodow values('Scania')
insert into MarkiSamochodow values('Daf')
insert into MarkiSamochodow values('Tata')



insert into ModeleSamochodow values ('Passat',1,'Osobowy') 
insert into ModeleSamochodow values ('Bora',1,'Osobowy')
insert into ModeleSamochodow values ('Polo',1,'osobowy')
insert into ModeleSamochodow values ('Touran',1,'Osobowy')

insert into ModeleSamochodow values ('Kadett',2,'Osobowy')
insert into ModeleSamochodow values ('Zafira',2,'Osobowy')
insert into ModeleSamochodow values ('Astra',2,'Osobowy')

insert into ModeleSamochodow values ('A3',3,'Osobowy')
insert into ModeleSamochodow values ('A4',3,'Osobowy')
insert into ModeleSamochodow values ('A6',3,'Osobowy')
insert into ModeleSamochodow values ('A8',3,'Osobowy')

insert into ModeleSamochodow values ('C 204 Lift',27,'Osobowy')

insert into ModeleSamochodow values ('ACTROS 1845',27,'Ciezarowy')
insert into ModeleSamochodow values ('BIGSPACE 1851',27,'Ciezarowy')

insert into ModeleSamochodow values ('R420',28,'Ciezarowy')
insert into ModeleSamochodow values ('R480',28,'Ciezarowy')
insert into ModeleSamochodow values ('R500',28,'Ciezarowy')
insert into ModeleSamochodow values ('R560',28,'Ciezarowy')

insert into ModeleSamochodow values ('XF SSC 105.460',29,'Ciezarowy')
insert into ModeleSamochodow values ('XF 410',29,'Ciezarowy')


insert into DaneSamochodu values (7,'2005','19 000','11705','diesel','manualna',1,'2015-01-02','2015-03-01','2015-01-01','niebieski','OPR123',2,'54 250','2','Truck','Polska',0)
insert into DaneSamochodu values (8,'2011','710 000','12700','diesel','manualna',1,'2015-01-02','2015-03-01','2015-01-01','czerwony','OPR456',2,'158 999','5','Truck','Polska',1)
insert into DaneSamochodu values (9,'2011','7100000','13500','diesel','manualna',1,'2015-01-02','2015-03-01','2015-01-01','czarny','OP23132',3,'209 000','5','Truck','Polska',0)
insert into DaneSamochodu values (10,'2011','5123489','12500','diesel','manualna',1,'2015-01-02','2015-03-01','2015-01-01','czarny','OP23132',1,'235 000','5','Truck','Polska',0)

--idModelu,rok,przebieg,pojemnosc,paliwo,skrzynia,bezwypadkowy?,data_przegladu,data,ubezpieczenia,dataprzyjecia,kolor,nrRej,idKlienta,Cena,liczbaDrzwi,rodzajNadwozia,kraj
insert into DaneSamochodu values (1,'1998','199 232','1899','diesel','manualna',1,'2015-01-02','2015-03-01','2015-01-01','czarny','OP23132',1,'19 999','5','Kombi','Polska',1)
insert into DaneSamochodu values (2,'1994','434 331','1623','benzyna','manualna',1,'2015-02-01','2015-01-01','2014-12-12','czarny','OB23235',1,'8 549','5','Hatchback','Polska',1)
insert into DaneSamochodu values (3,'1996','99 111','1599','benzyna','manualna',1,'2015-03-02','2015-01-01','2014-12-01','niebieski','OK32345',1,'6 549','3','Hatchback','Niemcy',1)
insert into DaneSamochodu values (9,'2005','64 565','1899','diesel','manualna',1,'2014-03-02','2015-11-01','2014-12-01','niebieski','OK24335',1,'6 549','3','Hatchback','Niemcy',1)
insert into DaneSamochodu values (5,'1988','3 232','1799','benzyna','manualna',1,'2015-03-02','2015-01-01','2014-12-01','szary','OPR32321',1,'6 549','3','sedan','Niemcy',1)
insert into DaneSamochodu values (6,'1996','99 111','1599','benzyna','manualna',1,'2015-03-02','2015-01-01','2014-12-01','niebieski','OK24335',1,'6 549','3','Hatchback','Niemcy',1)


insert into WyposazenieDodatkowe values(1,1,1,1,1,1,0,0)
insert into WyposazenieDodatkowe values(2,1,0,1,0,1,0,0)
insert into WyposazenieDodatkowe values(3,0,1,1,1,1,0,0)

insert into ZalaczoneDokumenty values (1,'Ksiązka serwisowa')
insert into ZalaczoneDokumenty values (1,'Instrukcja obsługi')
insert into ZalaczoneDokumenty values (2,'Karta do parkomatu')
insert into ZalaczoneDokumenty values (3,'Dowód rejestracyjny')



