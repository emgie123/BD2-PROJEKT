using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using BestSales.Models.DbInsert;
using BestSales.Models.DB;


namespace BestSales.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
     
            DB2KomisDataBaseEntities dbAccess = new DB2KomisDataBaseEntities
            {
                CarDisplayCondtions = (x, y) => ((DaneSamochodu) x).Wyrozniony
            };

   
            return View(dbAccess);

        }

   
        public ActionResult About()
        {

            return View();
        }

        public ActionResult Map()
        {

            return View();
        }

   
        public ActionResult Contact()
        {

            return View();
        }


       
    }
}
