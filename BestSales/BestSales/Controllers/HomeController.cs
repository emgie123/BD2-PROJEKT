using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using BestSales.Models.DbInsert;
using BestSales.Models.DB;
using BestSales.Models.UserInfo;
using BestSales.Logic.User;
using BestSales.Interfaces;


namespace BestSales.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        protected IUserLogic UserLogic;

        public HomeController()
        {
            UserLogic = new UserLogic();
        }
        public HomeController(IUserLogic logic)
        {
            UserLogic = logic;
        }

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

        public ActionResult ShowUser(int userid)
        {


            User user = UserLogic.GetUSers()[userid]; //Factories.UserInfo[int.Parse(userid)];

           // var dupa = Factories.abc.Value;
            
            //AutoMapper

            /*
            if (int.Parse(userid) == 1)
            {
                user = new User("mg.png", "Garbacz Michał", "Junior Web Developer");
                user.SetDetails("DEVELOPERS", "987654321", "majkel@BestSales.com", new List<string>() { "Programowanie", "Bazy Danych" }, new List<string>() { "ASP.NET MVC, JavaScript, SQL" });
            }
            else if (int.Parse(userid) == 2)
            {
                user = new User("robson.jpeg", "Winkler Robert", "Junior Web Developer");
                user.SetDetails("DEVELOPERS", "123456789", "robson@BestSales.com", new List<string>() {"Technologie internetowe", "Programowanie"}, new List<string>() { "ASP.NET MVC, JavaScript, HTML, CSS" });
            }*/
            if (Request.IsAjaxRequest())
            {
                return PartialView("~/Views/Partials/ContactPartial.cshtml", user);
            }
            return View("Contact", user);
        }

       
    }
}
