using balaitani_psd.Model;
using balaitani_psd.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace balaitani_psd.Repository
{
    public class ProductRepository
    {
        private static MainDatabaseEntities db = Database.GetDatabase();

        public static Product GetProductById(int id)
        {
            Product product = db.TransactionDetail.Find(id);

            return product;
        }

        public static List<Product> GetAllProducts()
        {
            return db.TransactionDetail.ToList();
        }

        public static Product AddProduct(Product product)
        {
            db.TransactionDetail.Add(product);
            db.SaveChanges();

            return product;
        }

        public static Product UpdateProduct(Product product)
        {
            db.SaveChanges();
            return product;
        }

        public static bool DeleteProduct(Product product)
        {
            db.TransactionDetail.Remove(product);
            try
            {
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}