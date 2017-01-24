using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBustersWMU1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Om oss.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt.";

            return View();
        }
        public ActionResult Products()
        {
            ViewBag.Message = "Produkter.";

            return View();
        }
    }
}