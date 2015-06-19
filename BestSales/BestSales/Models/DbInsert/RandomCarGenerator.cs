using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using BestSales.Models.DB;

namespace BestSales.Models.DbInsert
{
     public class RandomCarGenerator
    {
        private readonly Random _generator;
         private ImageGenerator _img;

        public RandomCarGenerator()
            {
                _generator= new Random();
                _img = new ImageGenerator(); 
            }

       
        public void InsertRandomCar()
        {
            using (var dbAccess = new DB2KomisDataBaseEntities())
            {

                dbAccess.DaneSamochodu.Add(ReturnRandomCar());
                dbAccess.SaveChanges();

            }

        }

         public static string query;

         public DaneSamochodu ReturnRandomCar()
         {
             DaneSamochodu samochod;
             using (var dbAccess = new DB2KomisDataBaseEntities())
             {
                 if(!dbAccess.MarkiSamochodow.Any()) throw new Exception("Brak marek samochodów w bazie");
                 if(!dbAccess.ModeleSamochodow.Any()) throw new Exception("Brak modeli samochodów w bazie");
                
                 var idModelu = dbAccess.ModeleSamochodow.Select(x => x.IdModelu).ToList().ElementAt(LosujLiczbe(dbAccess.ModeleSamochodow.Select(x => x.IdModelu).ToList().Count));
                 var idMarki =  dbAccess.ModeleSamochodow.Where(x => x.IdModelu == idModelu).Select(z => z.IdMarki).ToList().First();

                 var nazwaModelu = dbAccess.ModeleSamochodow.First(x => x.IdModelu == idModelu).Model;
                 var nazwaMarki = dbAccess.MarkiSamochodow.First(x => x.IdMarki == idMarki).Marka;
                 var kolor = Enum.GetName(typeof(KoloryEnum), (KoloryEnum)LosujLiczbe(Enum.GetNames(typeof(KoloryEnum)).Count())).ToLower();


                 query = (String.Format("{0} {1}", nazwaMarki, nazwaModelu));

                 _img.GetRandomImage(String.Format("{0} {1}",nazwaMarki, nazwaModelu));
                
                 samochod = new DaneSamochodu()
                 {
                     IdModelu = idModelu,
                     RokProdukcji = LosujLiczbe(2016, 1980).ToString(),
                     Przebieg = LosujLiczbe(250000, 4999).ToString("### ### ###"),
                     Pojemnosc = LosujLiczbe(3000,700).ToString("### ### ###"),
                     RodzajPaliwa = Enum.GetName(typeof(RodzajePaliwaEnum), (RodzajePaliwaEnum)LosujLiczbe(Enum.GetNames(typeof(RodzajePaliwaEnum)).Count())).ToLower(),
                     SkrzyniaBiegow = Enum.GetName(typeof(SkrzynieBiegowEnum), (SkrzynieBiegowEnum)LosujLiczbe(Enum.GetNames(typeof(SkrzynieBiegowEnum)).Count())).ToLower(),
                     Bezwypadkowy = Convert.ToBoolean(LosujLiczbe(2)),
                     DataPrzegladu = RandomDay(),
                     DataUbezpieczenia = RandomDay(),
                     DataPzyjecia = RandomDay(),
                     Kolor = kolor,
                     NrRejestracyjny = String.Format("{0}{1}{2}", (char)LosujLiczbe(91, 65), (char)LosujLiczbe(91, 65), LosujLiczbe(99999, 10000)),
                     IdKlienta = dbAccess.Klienci.Select(x => x.IdKlienta).ToList().ElementAt(LosujLiczbe(dbAccess.Klienci.Select(x => x.IdKlienta).ToList().Count)),
                     Cena = LosujLiczbe(100000).ToString("### ### ###"),
                     LiczbaDrzwi = ((int)((LiczbaDrzwiEnum)LosujLiczbe(Enum.GetNames(typeof(LiczbaDrzwiEnum)).Count(),2))).ToString().ToLower(),
                     RodzajNadwozia = Enum.GetName(typeof(RodzajNadwoziaEnum), (RodzajNadwoziaEnum)LosujLiczbe(Enum.GetNames(typeof(RodzajNadwoziaEnum)).Count())).ToLower(),
                     KrajPochodzenia = Enum.GetName(typeof(KrajePochodzeniaEnum), (KrajePochodzeniaEnum)LosujLiczbe(Enum.GetNames(typeof(KrajePochodzeniaEnum)).Count())),
                     Wyrozniony = Convert.ToBoolean(LosujLiczbe(2))
                 };

                     

             }

             return samochod;
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
    
         
        public readonly Dictionary<string, string> TranslateColour = new Dictionary<string, string>()
        {
            {"CZARNY","Black"},
            {"BIAŁY","Black"},
            {"GRANATOWY","Navy Blue"},
            {"ŻÓŁTY","Yellow"},
            {"SZARY","Gray"},
            {"SREBRNY","Silver"},
            {"NIEBIESKI","Blue"},
            {"CZERWONY","Red"},
            {"ZIELONY","Green"},
            {"BRĄZOWY","Brown"},

        };
    

    }
}