using System.Web.Mvc;
using BestSales.Models.DB;

namespace BestSales.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Bd2KomisDataBaseEntities dbAccess = new Bd2KomisDataBaseEntities();
       

            return View(dbAccess);
        }

    }
}
