using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class ShoppingCart
    {
        internal List<Product> products;

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            products.Add(product);
        }
        public void DisplayCart()
        {
            foreach (var product in products)
            {
                product.Display();
            }
        }
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Price * product.Count;
            }
            return total;
        }

    }
}
