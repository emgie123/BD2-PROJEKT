using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using BestSales.Models.DB;

namespace BestSales.Models.DbInsert
{
     class RandomCarGenerator
    {
        private readonly Random _generator;

        public RandomCarGenerator()
            {
                _generator= new Random();
            }

         //TODO metoda formatująca cenę i przebieg(spacje) (tj. 442, 1 439 , 13 043, 132 302, 1 323 043) ...
         //TODO metoda zasysająca randomowe zdjecia z neta(dla merceda to haslo klucz mercedes itd :D) i wrzucajace je do odpowiedniego folderu
        public void InsertRandomCar()
        {

            using (var dbAccess = new DB2KomisDataBaseEntities())
            {
               
               dbAccess.DaneSamochodu.Add(new DaneSamochodu()
                {
                    IdModelu = dbAccess.ModeleSamochodow.Select(x => x.IdModelu).ToList().ElementAt(LosujLiczbe(dbAccess.ModeleSamochodow.Select(x => x.IdModelu).ToList().Count)),
                    RokProdukcji = LosujLiczbe(2016, 1980).ToString(),
                    Przebieg = LosujLiczbe(250000).ToString(),
                    Pojemnosc = LosujLiczbe(3000).ToString(),
                    RodzajPaliwa = Enum.GetName(typeof(RodzajePaliwaEnum), (RodzajePaliwaEnum)LosujLiczbe(Enum.GetNames(typeof(RodzajePaliwaEnum)).Count())).ToLower(),
                    SkrzyniaBiegow = Enum.GetName(typeof(SkrzynieBiegowEnum), (SkrzynieBiegowEnum)LosujLiczbe(Enum.GetNames(typeof(SkrzynieBiegowEnum)).Count())).ToLower(),
                    Bezwypadkowy = Convert.ToBoolean(LosujLiczbe(2)),
                    DataPrzegladu = RandomDay(),
                    DataUbezpieczenia = RandomDay(),
                    DataPzyjecia = RandomDay(),
                    Kolor = Enum.GetName(typeof(KoloryEnum), (KoloryEnum)LosujLiczbe(Enum.GetNames(typeof(KoloryEnum)).Count())).ToLower(),
                    NrRejestracyjny = String.Format("{0}{1}{2}", (char)LosujLiczbe(91, 65), (char)LosujLiczbe(91, 65), LosujLiczbe(99999, 10000)),
                    IdKlienta = dbAccess.Klienci.Select(x => x.IdKlienta).ToList().ElementAt(LosujLiczbe(dbAccess.Klienci.Select(x => x.IdKlienta).ToList().Count)),
                    Cena = LosujLiczbe(150000).ToString(),
                    LiczbaDrzwi = ((int)((LiczbaDrzwiEnum)LosujLiczbe(Enum.GetNames(typeof(LiczbaDrzwiEnum)).Count()))).ToString().ToLower(),
                    RodzajNadwozia = Enum.GetName(typeof(RodzajNadwoziaEnum), (RodzajNadwoziaEnum)LosujLiczbe(Enum.GetNames(typeof(RodzajNadwoziaEnum)).Count())).ToLower(),
                    KrajPochodzenia = Enum.GetName(typeof(KrajePochodzeniaEnum), (KrajePochodzeniaEnum)LosujLiczbe(Enum.GetNames(typeof(KrajePochodzeniaEnum)).Count())),
                    Wyrozniony = Convert.ToBoolean(LosujLiczbe(2))
                }

                   );

               dbAccess.SaveChanges(); }  
            

  
        }

        private int LosujLiczbe (int koniecOtwarty,int start = 0)
        {
            return _generator.Next(start, koniecOtwarty);
        }

        DateTime RandomDay()
        {
            DateTime start = new DateTime(2014, 1, 1);

            int range = (DateTime.Today - start).Days;
            return start.AddDays(_generator.Next(range)).Date;
        }
    


    }
}