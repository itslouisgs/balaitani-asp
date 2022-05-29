using balaitani_psd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Handler
{
    public class ProductHandler
    {
        public static Product GetProductById(int id)
        {
            return ProductRepository.GetProductById(id);
        }

        public static List<Product> GetAllProducts()
        {
            return ProductRepository.GetAllProducts();
        }

        public static Product addProduct(Product product)
        {
            return ProductRepository.addProduct(product);
        }
    }
}