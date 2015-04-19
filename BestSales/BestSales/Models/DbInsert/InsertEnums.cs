using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestSales.Models.DbInsert
{

    public enum MarkiSamochodowEnum
    {
        Volkswagen,
        Opel,
        Audi,
        Honda,
        Toyota,
        Hyundai,
        Chrysler,
        KIA,
        Ford,
        Jeep,
        Bugatti,
        Ferrari,
        Porsche,
        Lamborghini,
        Dodge,
        Nissan,
        Mitsubishi,
        AstonMartin,
        AlfaRomeo,
        Bentley,
        Citroen,
        Dacia,
        Fiat,
        Lancia,
        Maseratti,
        Peugeot,
        Mercedes,
        Scania,
        Daf,
        Tata
    }

    public enum ModeleSamochodowEnum
    {
        Passat,
        Bora,
        Polo,
        Touran,
        Kadett,
        Zafira,
        Astra,
        A3,
        A4,
        A6,
        A8,
        R420,
        R480,
        R500,
        R560,
        XFSSC105460,
        XF410,
        ACTROS,
        BIGSPACE,
        C204Lift  
    }

    public enum TypyPojazdowEnum
    {
        Osobowy,
        Ciezarowy
    }

    public enum BezwypadkowyEnum
    {   
        PoWypadku,
        Bezwypadkowy
    }

    public enum RodzajePaliwaEnum
    {
        Benzyna,
        Diesel,
        Gaz
    }

    public enum SkrzynieBiegowEnum
    {
        Manualna,
        Automatyczna,
        Semiautomatic
    }

    public enum KoloryEnum
    {
       
        Czarny,
        Biały,
        Granatowy,
        Żółty,
        Szary,
        Srebrny,
        Niebieski,
        Czerwony,
        Zielony,
        Brązowy,

    }

    public enum LiczbaDrzwiEnum
    {
        Trzy=3,
        Cztery,
        Pięć
    }

    public enum RodzajNadwoziaEnum
    {
        Kombi,
        Sedan,
        Hatchback,
        Truck,
        LiftBack,
    
      
    }

    public enum KrajePochodzeniaEnum 
    {
        Polska,
        Niemcy,
        WielkaBrytania,
        Ukraina,
        Rosja,
        Szwajcaria
    }

    public enum WyroznionyEnum
    {
        Niewyrozniony,
        Wyrozniony
    }
}