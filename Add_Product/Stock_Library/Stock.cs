using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Product
{
   public class Stock
    {
        private Product[] products;
        private int index;

        public Stock(int ProductCount)
        {
            products = new Product[ProductCount];
        }


        public void AddProduct(Product product)
        {
            if (index < products.Length)
            {
                products[index] = product;
                index++;
            }
        }

    }
}
