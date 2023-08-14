using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Biyografi_Mvc.Models.Sınıflar;

namespace Biyografi_Mvc.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var degerler = db.Saraylars.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {


            return View();




        }

        public ActionResult Contact()
        {
            var degerler = db.Heykellers.ToList();
            return View(degerler);

            
        }
    }
}