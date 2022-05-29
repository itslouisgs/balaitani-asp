using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Factory
{
    public class ProductFactory
    {
        public static Product Create(string name, string description, int price, int stock)
        {
            Product newProduct = new Product
            {
                name = name,
                description = description,
                price = price,
                stock = stock
            };

            return newProduct;
        }
    }
}