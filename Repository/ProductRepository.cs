using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace balaitani_psd.Repository
{
    public class ProductRepository
    {
        private static MainDatabaseEntities db = new MainDatabaseEntities();

        public static Product GetProductById(int id)
        {
            Product product = db.Products.Find(id);

            return product;
        }

        public static List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public static Product AddProduct(Product product)
        {
            db.Products.Add(product);
            Debug.WriteLine(product);
            db.SaveChanges();

            return product;
        }
    }
}