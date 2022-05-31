using balaitani_psd.Model;
using balaitani_psd.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Repository
{
    public class ShippingRepository
    {
        private static MainDatabaseEntities db = Database.GetDatabase();

        public static List<Shipping> GetAllShippings()
        {
            return db.Shippings.ToList();
        }
    }
}