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
            try
            {
                var id = 0;
                var order = new Order();
                TryUpdateModel(order);
                db.Orders.InsertOnSubmit(order);
                // checks if input in the checkout form is valid through the model(database)
                if (ModelState.IsValid)
                {
                    //looks up items in the Cart and decrease item amount from the database 
                    List<ShoppingCart> cartList = (List<ShoppingCart>) Session["Cart"];
                    foreach (var item in cartList)
                    {
                        id = item.Item.ArticleId;
                        var query =
                            from ord in db.Products
                            where ord.ArticleId == id
                            select ord;
                        foreach (Product product in query)
                        {

                            product.Remaining--;

                            // to check for possible quantity errors 
                            // redirect the customer to an error page in that case.
                            if (product.Remaining < 0)
                            {
                                return RedirectToAction("ContactCustomerService");
                            }
                        }
                    }

                    db.SubmitChanges();
                    Session["Cart"] = null;
                    return RedirectToAction("CheckoutComplete", new {id = order.OrderId});
                }

                return View();
            }
            // if other problems occur
            catch
            {
                return RedirectToAction("ContactCustomerService");
            }
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


        public ActionResult ContactCustomerService()
        {
            return View();
        }
    }
}
