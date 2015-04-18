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

         
            DbInsert insert = new DbInsert();
           // insert.AddRandomCar();
            ImageGenerator img = new ImageGenerator();
            img.GetRandomImage("mercedes");


            DB2KomisDataBaseEntities dbAccess = new DB2KomisDataBaseEntities
            {
                CarDisplayCondtions = (x, y) => ((DaneSamochodu) x).Wyrozniony
            };
            // dbAccess.Database.ExecuteSqlCommand(query);
            
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
