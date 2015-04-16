using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestSales.Models.DB;

namespace BestSales.Controllers
{
    public class OffersController : Controller
    {
        //
        // GET: /Offers/

        public ActionResult Offers(string category, int? filter)
        {
            // @Model.MarkiSamochodow.First(x=>x.IdMarki==(Model.ModeleSamochodow.FirstOrDefault(y=>y.IdModelu==car.IdModelu).IdMarki)).IdMarki==filter
            DB2KomisDataBaseEntities dbAccess = new DB2KomisDataBaseEntities();

            if (filter != null)
            {
                dbAccess.CarDisplayCondtions = (x, y) => (y.MarkiSamochodow.First(z => z.IdMarki == (y.ModeleSamochodow.FirstOrDefault(
                    v=> v.IdModelu == ((DaneSamochodu)x).IdModelu).IdMarki)).IdMarki == filter);
            }
            else dbAccess.CarDisplayCondtions = (x, y) => true;
            

            return View(dbAccess);
        }

    }
}
