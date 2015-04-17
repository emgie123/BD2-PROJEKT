using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BestSales.Models.DB;

namespace BestSales.Models.DbInsert
{
    public class DbInsert
    {

        private readonly Verifiers _verifier;
        public DbInsert()
        {
            _verifier= new Verifiers();
            using (var dbConnnection = new DB2KomisDataBaseEntities())
            {
                _verifier.VerifyBrandsNumber(dbConnnection);
                _verifier.VerifyModelsNumber(dbConnnection);
            }
        }

     
        public void AddCarBrand(string brand)
        {
            using (var dbConnnection = new DB2KomisDataBaseEntities())
            {
                _verifier.VerifyBrandName(brand, dbConnnection);
                // VerifyBrandsNumber(marka, dbConnnection);


                dbConnnection.MarkiSamochodow.Add(new MarkiSamochodow() { Marka = brand });
                dbConnnection.SaveChanges();
            }

        }

        public void AddCarModel(MarkiSamochodowEnum marka, string model, TypyPojazdowEnum typAuta)
        {

            using (var dbConnnection = new DB2KomisDataBaseEntities())
            {

                _verifier.VerifyModeldName(model, dbConnnection);
                dbConnnection.ModeleSamochodow.Add(new ModeleSamochodow() { Model = model, IdMarki = (int)marka, TypSamochodu = Enum.GetName(typeof(TypyPojazdowEnum), typAuta).ToLower() });
                dbConnnection.SaveChanges();
            }

        }

        public void AddCar(ModeleSamochodowEnum model, string rokProdukcji,string przebieg,string pojemnosc,
            RodzajePaliwaEnum rodzajPaliwa,SkrzynieBiegowEnum skrzyniaBiegow,BezwypadkowyEnum bezwypadkowy,
            DateTime dataPrzegladu,DateTime dataUbezpieczenia,DateTime dataPrzyjecia, KoloryEnum kolor,
            string nrRejestracyjny, LiczbaDrzwiEnum liczbaDrzwi,int idKlienta, string cena,
            RodzajNadwoziaEnum rodzajNadwozia,KrajePochodzeniaEnum krajPochodzenia, WyroznionyEnum wyrozniony)
        {
            
            using(var dbAccess = new DB2KomisDataBaseEntities())
            {
                _verifier.CheckIfModelExists(dbAccess, model);

                dbAccess.DaneSamochodu.Add(new DaneSamochodu()
                {
                   IdModelu = (int)model,
                   RokProdukcji = rokProdukcji,
                   Przebieg = przebieg,
                   Pojemnosc = pojemnosc,
                   RodzajPaliwa = Enum.GetName(typeof(RodzajePaliwaEnum),rodzajPaliwa),
                   SkrzyniaBiegow = Enum.GetName(typeof(SkrzynieBiegowEnum), skrzyniaBiegow),
                   Bezwypadkowy = Convert.ToBoolean(bezwypadkowy),
                   DataPrzegladu = dataPrzegladu.Date,
                   DataUbezpieczenia = dataUbezpieczenia.Date,
                   DataPzyjecia = dataPrzyjecia.Date,
                   Kolor = Enum.GetName(typeof(SkrzynieBiegowEnum), skrzyniaBiegow),
                   NrRejestracyjny = nrRejestracyjny,
                   IdKlienta = idKlienta,
                   Cena = cena,
                   LiczbaDrzwi = liczbaDrzwi.ToString(),
                   RodzajNadwozia = Enum.GetName(typeof(RodzajNadwoziaEnum), rodzajNadwozia),
                   KrajPochodzenia = Enum.GetName(typeof(KrajePochodzeniaEnum), krajPochodzenia),
                   Wyrozniony = Convert.ToBoolean(wyrozniony)


                }
                    );

                dbAccess.SaveChanges();

            }
        }


        public void AddRandomCar()
        {
            RandomCarGenerator rcg = new RandomCarGenerator();
            rcg.InsertRandomCar();
        }

     


    }
}