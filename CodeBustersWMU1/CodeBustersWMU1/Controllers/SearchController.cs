using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBustersWMU1.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult SearchDetails()
        {
            var product =
from p in db.Products
where p.ArticleId == id
select p;
            return View();
        }
    }
}