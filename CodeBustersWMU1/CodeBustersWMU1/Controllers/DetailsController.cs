using CodeBustersWMU1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBustersWMU1.Controllers
{
    public class DetailsController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();



        // GET: Description/Details/5
        public ActionResult Details(int id)
        {
            
            ViewBag.Message = "Details";

            List<Product> allProducts = db.Products.ToList();

            foreach(var product in allProducts)
            {
                if(product.ArticleId == id)
                {
                    ViewData["Product"] = product;

                    ViewData["Description"] = product.Description;
                    ViewData["ArticleName"] = product.ArticleName;
                    ViewData["Price"] = product.Price;
                    ViewData["Image"] = product.Image;
                    ViewData["ArticleId"] = product.ArticleId;
                    ViewData["Remaining"] = product.Remaining;
                    break;
                }
            }
            return View(db.Products.ToList());
        }


        // GET: Description/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult _PopularProducts()
        {

            return PartialView();
        }

    }
}
