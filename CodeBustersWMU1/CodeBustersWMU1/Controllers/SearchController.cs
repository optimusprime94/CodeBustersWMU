using CodeBustersWMU1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBustersWMU1.Controllers
{
    public class SearchController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Search
        public ActionResult SearchDetails()
        {
            //var order =
            //from p in db.Orders
            //where p.ArticleId == id
            //select p;
            return View(db.Orders.ToList());
        }
    }
}