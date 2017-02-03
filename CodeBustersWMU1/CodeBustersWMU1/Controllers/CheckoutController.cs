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
            //int aID = 0;
            //int quantity, i;
            //i = 0;
            //quantity = 0;
            //  aID = new int[10];
            var id = db.Orders.Select(q => q.OrderId).Max();
         
            int idOrder = Convert.ToInt16(id);

            //List<ShoppingCart> cartList = (List<ShoppingCart>)Session["Cart"];
            //foreach (var item in cartList)
            //{
            //    aID = item.Item.ArticleId;
            //    quantity = item.Quantity;
            //    i++;
            //}

            Order order = new Models.Order
            {
                OrderId = (idOrder + 1),
                FirstName = collection["Förnamnbox"],
                SurName = collection["Efternamnbox"],
                SocialSecurityNumber = Convert.ToInt64(collection["Personnrbox"]),
                Adress = collection["Postadressbox"],
                PostalCode = Convert.ToInt32(collection["Postnrbox"]),
                City = collection["Ortbox"],
                Email = collection["Epostbox"],
                Phone = Convert.ToInt32(collection["Telenrbox"]),

            };
            //OrderDetail detail = new Models.OrderDetail
            //{
            //    ArtikcleID = aID,
            //    OrderID = idOrder,
            //    Amount = quantity
            //};
            db.Orders.InsertOnSubmit(order);
           // db.OrderDetails.InsertOnSubmit(detail);
            try
            {
                // TODO: Add insert logic here
                db.SubmitChanges();

                return RedirectToAction("Checkout");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult AddCartToOrder()
{

        //    List<ShoppingCart> cartList = (List<ShoppingCart>)Session["Cart"];
        //    foreach (var item in cartList)
        //    {

        //        aID = item.Item.ArticleId;
        //        quantity = item.Quantity;

    //}
    return View();
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
