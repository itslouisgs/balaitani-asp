using balaitani_psd.Factory;
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

        public static string addProduct(int id, string name, int price, int stock, string description, string image, int seller_id)
        {
            if (id < 1 || name.Length < 1 || price < 1 || stock < 1 || description.Length < 1 || image.Length < 1 || seller_id < 1)
            {
                return "All fields must be filled!";
            }

            Product product = ProductFactory.Create(id, name, price, stock, description, image, seller_id);
            ProductHandler.addProduct(product);
            return "Product added succesfully";
        }
    }
}