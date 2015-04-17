using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestSales.Models.DbInsert
{
    public static class Factories
    {
        public static Dictionary<ModeleSamochodowEnum, int> ModelToBrand = new Dictionary<ModeleSamochodowEnum, int>()
        {   //VW
            {ModeleSamochodowEnum.Passat,1},
            {ModeleSamochodowEnum.Bora,1},
            {ModeleSamochodowEnum.Polo,1},
            {ModeleSamochodowEnum.Touran,1},

            //OPEL
            {ModeleSamochodowEnum.Touran,2},
            {ModeleSamochodowEnum.Kadett,2},
            {ModeleSamochodowEnum.Zafira,2},
            {ModeleSamochodowEnum.Astra,2},

            //Audi
            {ModeleSamochodowEnum.A3,3},
            {ModeleSamochodowEnum.A4,3},
            {ModeleSamochodowEnum.A6,3},
            {ModeleSamochodowEnum.A8,3},

            //Mercedes
            {ModeleSamochodowEnum.ACTROS,27},
            {ModeleSamochodowEnum.BIGSPACE,27},
            {ModeleSamochodowEnum.C204Lift,27},

            //Scania
            {ModeleSamochodowEnum.R420,28},
            {ModeleSamochodowEnum.R480,28},
            {ModeleSamochodowEnum.R500,28},
            {ModeleSamochodowEnum.R560,28},

            //DAF
            {ModeleSamochodowEnum.XF410,29},
            {ModeleSamochodowEnum.XFSSC105460,29},
        };
    }
}