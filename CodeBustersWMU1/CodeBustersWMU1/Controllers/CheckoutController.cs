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

            var id = db.Orders.Select(q => q.OrderId).Max();
            //from o in db.Orders
            //select o.OrderId;
            int idOrder = Convert.ToInt16(id);

            Order order = new Models.Order
            {
                OrderId = (idOrder+1),
                FirstName = collection["Förnamnbox"],
                SurName = collection["Efternamnbox"],
                SocialSecurityNumber = Convert.ToInt64(collection["Personnrbox"]),
                Adress = collection["Postadressbox"],
                PostalCode = Convert.ToInt32(collection["Postnrbox"]),
                City = collection["Ortbox"],
                Email = collection["Epostbox"],
                Phone = Convert.ToInt32(collection["Telenrbox"]),
            };

            db.Orders.InsertOnSubmit(order);
            try
            {
                // TODO: Add insert logic here
                //   order.OrderId = 2;
                //order.
                //string FirstName = collection["Förnamnbox"];
                //string SurName = collection["Efternamnbox"];
                //Int64 SocialSecurityNumber = Convert.ToInt64(collection["Personnrbox"]);
                //string Adress = collection["Postadressbox"];
                //int PostalCode = Convert.ToInt32(collection["Postnrbox"]);
                //string City = collection["Ortbox"];
                //string Email = collection["Epostbox"];
                //int Phone = Convert.ToInt32(collection["Telenrbox"]);


                db.SubmitChanges();
               
                return RedirectToAction("Checkout");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CheckoutComplete()
        {

            return View();
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
