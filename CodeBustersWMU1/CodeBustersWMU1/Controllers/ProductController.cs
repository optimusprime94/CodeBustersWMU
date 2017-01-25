using CodeBustersWMU1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBustersWMU1.Controllers
{
    public class ProductController : Controller
    {
        

        

        // GET: Product
        public ActionResult Products()
        {
            var db = new DataClasses1DataContext();

            return View(db.Products.ToList());
        }

    }
}
