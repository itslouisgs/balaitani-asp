using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Factory
{
    public class ProductFactory
    {
        public static Product Create(string name, int price, int stock, string image, string description, int seller_id)
        {
            Product newProduct = new Product
            {
                name = name,
                price = price,
                stock = stock,
                description = description,
                image = image,
                seller_id = seller_id
            };

            return newProduct;
        }
    }
}