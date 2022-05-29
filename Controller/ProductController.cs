using balaitani_psd.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Controller
{
    public class ProductController
    {
        public static Product GetProductById(int id)
        {
            return ProductHandler.GetProductById(id);
        }

        public static List<Product> GetAllProducts()
        {
            return ProductHandler.GetAllProducts();
        }
    }
}