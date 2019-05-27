using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult test()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Client()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Organizator()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AdaugaConcert()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]


        public ActionResult AdaugaConcert(Evenimente evenimente)
        {
          
            return View("AdaugaConcert");
        }

      

        public ActionResult Rezervare()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     
    }
}