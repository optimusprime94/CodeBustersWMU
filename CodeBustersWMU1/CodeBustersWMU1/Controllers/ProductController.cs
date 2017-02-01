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

        public ActionResult ShoppingBag()
        {
            return View();
        }


        public ActionResult AddToCart(int id)
        {
            var session = HttpContext.Session;
            
            // we need a shopping cart if we dont already have one.
            if (session["Cart"] == null)
            {
                Session["Cart"] = new List<ShoppingCart>();
                
            }

            List<ShoppingCart> cartList = (List<ShoppingCart>)Session["Cart"]; // we get the shoppinglist

            // if the item is already in the shopping list
            foreach (var item in cartList)
            {
                if (item.Item.ArticleId == id)
                {
                    item.Quantity++;
                    return RedirectToAction("ShoppingBag");
                }
            }

            // if the element wasnt already in the list then
            // we need to query for it.
            var product =
                from p in db.Products
                where p.ArticleId == id
                select p;

            // Cart Item: so we can put the product inside of it.
            ShoppingCart cartItem = new ShoppingCart(); 

                cartItem.Item = product.First();
                //cartItem.Quantity = 1;

                // adds the cartItem to the list of shopping items.
                cartList.Add(cartItem);
                // Go back to the main store page for more shopping
                return RedirectToAction("ShoppingBag");
            

        }

        public ActionResult RemoveFromCart(int id)
        {
            var session = HttpContext.Session;


            if (session["Cart"] == null || id == 0)
            {
                // Cannot remove items...
                return RedirectToAction("ShoppingBag");

            }

            //We create a cartItem and put the product in the cartItem then
            //if the product exists as cartItem in cartList, we remove it.
            ShoppingCart cartItem = new ShoppingCart(); // Cart Item

            List<ShoppingCart> cartList = (List<ShoppingCart>)Session["Cart"];
            foreach(var item in cartList)
            {
                if(item.Item.ArticleId == id)
                {
                    if (item.Quantity == 1)
                    {
                        cartList.Remove(item);
                    }
                    item.Quantity--;
                    return RedirectToAction("ShoppingBag");
                }
            }
            
            // Go back to the main store page for more shopping
            return RedirectToAction("ShoppingBag");


        }
    }
}