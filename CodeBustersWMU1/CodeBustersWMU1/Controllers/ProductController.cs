﻿using CodeBustersWMU1.Models;
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

        public ActionResult ShoppingBag()
        {
            return View();
        }


        public ActionResult AddToCart(int id)
        {
            var session = HttpContext.Session;
            

            if (session["Cart"] == null)
            {
                Session["Cart"] = new List<ShoppingCart>();
                
            }
            var q =
                from p in db.Products
                where p.ArticleId == id
                select p;

            ShoppingCart item = new ShoppingCart(); // Cart Item

                item.Item = q.First();
                item.Quantity = 1;
                List<ShoppingCart> cartList = (List<ShoppingCart>)Session["Cart"];
                cartList.Add(item);
                // Go back to the main store page for more shopping
                return RedirectToAction("Products");
            

        }
    }
}