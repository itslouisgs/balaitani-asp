using balaitani_psd.Model;
using balaitani_psd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Handler
{
    public class ShippingHandler
    {
        public static List<Shipping> GetAllShippings()
        {
            return ShippingRepository.GetAllShippings();
        }
    }
}