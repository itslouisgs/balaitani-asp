using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Factory
{
    public class CartFactory
    {
        public static Cart Create(int user_id, int product_id, int quantity)
        {
            Cart newCart = new Cart
            {
                product_id = product_id,
                user_id = user_id,
                quantity = quantity
            };

            return newCart;
        }
    }
}