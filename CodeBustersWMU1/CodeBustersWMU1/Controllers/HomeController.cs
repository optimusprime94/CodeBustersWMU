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

    }
}