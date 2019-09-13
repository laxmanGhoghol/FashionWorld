using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionWorld.Controllers
{
    public class HomeController : Controller
    {
        Algos algos = new Algos();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TermsCondis()
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
    }
}