using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBustersWMU1.Models
{
    public class ShoppingCart
    {
        private int _quantity = 1;
        public Product Item { get; set; }
        public int Quantity {
            get {
                return this._quantity;
            }
            set {
                if (value >= 0) { 
                this._quantity = value;
                }
            }
        }
    }
}