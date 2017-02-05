using CodeBustersWMU1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBustersWMU1.Controllers
{
    public class CheckoutController : Controller
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Checkout
        public ActionResult Index()
        {

            return View();
        }

        // GET: Checkout/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Checkout/Checkout
        [HttpGet]
        public ActionResult Checkout()
        {
            return View();
        }

        // POST: Checkout/Checkout
        [HttpPost]
        public ActionResult Checkout(FormCollection collection)
        {
       
            var order = new Order();
            TryUpdateModel(order);
            db.Orders.InsertOnSubmit(order);

            if (ModelState.IsValid)
            {

           
                db.SubmitChanges();

                return RedirectToAction("CheckoutComplete", new { id = order.OrderId });
            }
            
                return View();
        }
public ActionResult CheckoutComplete(int id)
{
           
    return View(id);
}
// GET: Checkout/Edit/5
public ActionResult Edit(int id)
{
    return View();
}

// POST: Checkout/Edit/5
[HttpPost]
public ActionResult Edit(int id, FormCollection collection)
{
    try
    {
                // TODO: Add update logic here

            
                return RedirectToAction("Index");
    }
    catch
    {
        return View();
    }
}

// GET: Checkout/Delete/5
public ActionResult Delete(int id)
{
    return View();
}

// POST: Checkout/Delete/5
[HttpPost]
public ActionResult Delete(int id, FormCollection collection)
{
    try
    {
        // TODO: Add delete logic here

        return RedirectToAction("Index");
    }
    catch
    {
        return View();
    }
}
    }
}
