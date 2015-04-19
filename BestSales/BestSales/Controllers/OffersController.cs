using System.Linq;
using System.Web.Mvc;
using BestSales.Models.DbInsert;
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
                dbAccess.CarDisplayCondtions = (x, y) => ((y.MarkiSamochodow.First(z => z.IdMarki == (y.ModeleSamochodow.FirstOrDefault(
                v=> v.IdModelu == ((DaneSamochodu)x).IdModelu).IdMarki)).IdMarki == filter)&&(y.ModeleSamochodow.First(h=>h.IdModelu == ((DaneSamochodu)x).IdModelu ).TypPojazdu.ToUpper()==category.ToUpper()));
              

            }
            else dbAccess.CarDisplayCondtions = (x, y) => true;
            

            return View(dbAccess);
        }

        public ActionResult Generate(int amount)
        {
            RandomCarGenerator rcg = new RandomCarGenerator();

            for (int i = 0; i < amount; i++)
            {
                rcg.InsertRandomCar();
            }

            ViewBag.Amount = amount;

            return View();
        }

    }
}
