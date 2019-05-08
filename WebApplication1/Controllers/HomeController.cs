using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult CreareCont()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}