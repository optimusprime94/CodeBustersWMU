using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBustersWMU1.Models
{
    public class ShoppingCart
    {
        private int _quantity = 1;
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public Product Item { get; set; }
        public int Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                //Check with database what the item supply is first!
                var remaining =
                from p in db.Products
                where p.ArticleId == Item.ArticleId
                 select p.Remaining;

               int whatRemains = remaining.First();


                if(whatRemains - (value) >= 0)
                {
                    this._quantity = value;
                }

            }
        }
    }
}