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
            Product product = db.Products.Find(id);

            return product;
        }

        public static (List<Product>, int) GetAllProducts(int page = 1)
        {
            int itemPerPage = 8;
            return (db.Products.OrderBy(p => p.id).Skip((page - 1) * itemPerPage).Take(itemPerPage).ToList(),
                    db.Products.Count());
        }

        public static Product AddProduct(Product product)
        {
            db.Products.Add(product);
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
            db.Products.Remove(product);
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