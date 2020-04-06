using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS4200Team2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We’re dedicated to providing you with an unmatched experience by working together to do what’s right by you while doing what’s right for all. Our seven core values reflect our professional passions and personal convictions.";
            ViewBag.One = "1. Commit to Delivery Excellence.";
            ViewBag.Two = "2. Embrace Integrity and Openness";
            ViewBag.Three = "3. Practice Responsible Stewardship";
            ViewBag.Four = "4. Invest in an Exceptional Culture";
            ViewBag.Five = "5. Ignite Passion for the Greater Good";
            ViewBag.Six = "6. Strive to Innovate";
            ViewBag.Sev = "7. Live a Balanced Life";
            ViewBag.Eight = "";
            ViewBag.Nine = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}