using CodeBustersWMU1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBustersWMU1.Controllers
{
    public class HomeController : Controller
    {
        /* In the MVC structure when you call an actionlink, you invoke an action(method) in a controller that then
           returns a view. The action must have the same name as the view!!
           ActionLink("linkName", "ActionName", "ControllerName"), you can also send parameters to the action for the 
           next view. */

        //GET: Home/Index
        public ActionResult Index()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return View(db.Products.ToList());
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

    }
}