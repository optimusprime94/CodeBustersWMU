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
        DataClasses1DataContext db = new DataClasses1DataContext();



        // GET: Product
        public ActionResult Products()
        {
            return View(db.Products.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
