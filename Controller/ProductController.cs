using balaitani_psd.Factory;
using balaitani_psd.Handler;
using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

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

        public static string AddProduct(string name, int price, int stock, FileUpload imageFile, string description, int seller_id) //add img later
        {
            if (name.Length < 1 || price < 1 || stock < 1 || description.Length < 1)
            {
                return "All fields must be filled!";
            }
            else if (!imageFile.HasFile || !imageFile.FileName.EndsWith(".jpg"))
            {
                return "Image (.jpg) must be uploaded!";
            }

            Product product = ProductFactory.Create(name, price, stock, imageFile, description, seller_id);
            ProductHandler.AddProduct(product);
            return "Product added succesfully";
        }
    }
}