﻿using CodeBustersWMU1.Models;
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
        public ActionResult Search(FormCollection collection)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            try
            {
                // working like a charm.
                int id = Convert.ToInt32(collection["OrderId"]);
                var product =
                    from o in db.Orders
                    where o.OrderId == id
                    select o;

                if (product.Count() == 0)
                {
                    throw new Exception();
                }
                return View(product.ToList());

            }
            catch
            {
                return RedirectToAction("SearchNotFound");
            }
        }

        public ActionResult SearchNotFound()
        {
            return View();
        }
    }
}