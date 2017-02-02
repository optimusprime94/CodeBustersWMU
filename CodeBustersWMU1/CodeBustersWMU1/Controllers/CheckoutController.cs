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
        public ActionResult CheckoutOut(FormCollection collection)
        {

            var order = new Order();
            try
            {
                // TODO: Add insert logic here
                order.OrderId = 2;
                order.FirstName = collection["Förnamnbox"];
                order.SurName = collection["Efternamnbox"];
                order.SocialSecurityNumber = Convert.ToInt64(collection["Personnrbox"]);
                order.Adress = collection["Adressbox"];
                order.PostalCode = Convert.ToInt32(collection["Postnrbox"]);
                order.City = collection["Ortbox"];
                order.Email = collection["Epostbox"];
                order.Phone = Convert.ToInt32(collection["Telenrbox"]);
                Console.WriteLine(order.FirstName);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
