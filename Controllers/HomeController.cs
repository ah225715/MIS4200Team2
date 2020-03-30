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
            ViewBag.Message = "At Centric we have given a lot of thought to the Corporate Character we want to exhibit. This character includes: ";
            ViewBag.One = "1. Honesty and integrity in everything we do.";
            ViewBag.Two = "2. We have high ethical and moral values.";
            ViewBag.Three = "3. We are thorough. If it’s worth doing, it’s worth doing right and it deserves 100% of our attention.";
            ViewBag.Four = "4. We have a Spartan attitude about our business. We look at every cost very carefully and ask ourselves “If I were buying this with my money, would I spend it on this?”";
            ViewBag.Five = "5. We do what is right, not what is expedient. We do not take short - term gains at the expense of long-term values. Instead we focus on what is the right thing to do.";
            ViewBag.Six = "6. We are humble and respect all partners. Everyone at Centric is making a vital contribution to our success. We recognize the potential in every human being and are careful to involve everyone. We want each partner to be a confident, contributing member of the team.";
            ViewBag.Sev = "7. We look professional. We have a dress code at all our facilities and believe outward appearances say a lot about us and the company.";
            ViewBag.Eight = "8. We are courteous. Nice people attract nice people and courtesy is contagious.";
            ViewBag.Nine = "9. We are enthusiastic! Positive attitudes and optimism are a must in a fast-paced environment like ours. A positive outlook goes a long way.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}