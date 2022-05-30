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

        public static string AddProduct(string name, int price, int stock, string description) //add img later
        {
            if (name.Length < 1 || price < 1 || stock < 1 || description.Length < 1)
            {
                return "All fields must be filled!";
            }

            Product product = ProductFactory.Create(name, price, stock, description);
            ProductHandler.AddProduct(product);
            return "Product added succesfully";
        }
    }
}