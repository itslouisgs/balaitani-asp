using balaitani_psd.Model;
using balaitani_psd.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Repository
{
    public class CartRepository
    {
        private static MainDatabaseEntities db = Database.GetDatabase();
        public static Cart AddCart(Cart Cart)
        {
            db.Carts.Add(Cart);
            db.SaveChanges();

            return Cart;
        }

        public static Cart UpdateCart(Cart Cart)
        {
            db.SaveChanges();
            return Cart;
        }

        public static bool DeleteCart(Cart Cart)
        {
            db.Carts.Remove(Cart);
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

        public static bool ClearCart(List<Cart> carts)
        {
            db.Carts.RemoveRange(carts);
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