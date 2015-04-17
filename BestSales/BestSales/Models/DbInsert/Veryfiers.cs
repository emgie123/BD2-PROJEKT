using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BestSales.Models.DB;

namespace BestSales.Models.DbInsert
{
     class Verifiers
    {


        public void CheckIfModelExists(DB2KomisDataBaseEntities dbAccess, ModeleSamochodowEnum model)
        {
            if (
                dbAccess.ModeleSamochodow.All(
                    x => x.Model.ToUpper() != Enum.GetName(typeof(ModeleSamochodowEnum), model)))
            {
                dbAccess.Dispose();
                throw new Exception("Podany model nie widnieje w bazie");
            }
        }

        public void VerifyBrandName(string brand, DB2KomisDataBaseEntities dbConnnection)
        {
            if (!(dbConnnection.MarkiSamochodow.All(x => x.Marka.ToUpper() != brand.ToUpper())))
            {
                dbConnnection.Dispose();
                throw new Exception("Podana marka już istnieje");
            }

        }

        public void VerifyModeldName(string model, DB2KomisDataBaseEntities dbConnnection)
        {
            if (!(dbConnnection.ModeleSamochodow.All(x => x.Model.ToUpper() != model.ToUpper())))
            {
                dbConnnection.Dispose();
                throw new Exception("Podany model już istnieje");
            }

        }

        public void VerifyBrandsNumber(DB2KomisDataBaseEntities dbConnnection)
        {
            if (dbConnnection.MarkiSamochodow.Count() != Enum.GetNames(typeof(MarkiSamochodowEnum)).Count())
            {
                dbConnnection.Dispose();
                throw new Exception("W bazie znajduje się więcej aut niż w MarkiSamochodówEnum. Uaktualnij strukturę");
            }

        }

        public void VerifyModelsNumber(DB2KomisDataBaseEntities dbConnnection)
        {
            if (dbConnnection.ModeleSamochodow.Count() != Enum.GetNames(typeof(ModeleSamochodowEnum)).Count())
            {
                dbConnnection.Dispose();
                throw new Exception("W bazie znajduje się więcej modeli aut niż w ModeleSamochodowEnum. Uaktualnij strukturę");
            }

        }

   
    }
}