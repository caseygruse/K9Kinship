using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K9Kinship.Controllers
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

        public ActionResult Programs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Trainers()
        {
            return View();
        }

        public ActionResult Opportunities()
        {
            return View();
        }

        public ActionResult ADA()
        {
            return View();
        }
    }
}