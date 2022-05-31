using balaitani_psd.Model;
using balaitani_psd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Handler
{
    public class CartHandler
    {
        public static Cart AddCart(Cart Cart)
        {
            return CartRepository.AddCart(Cart);
        }

        public static Cart UpdateCart(Cart Cart)
        {
            return CartRepository.UpdateCart(Cart);
        }

        public static bool DeleteCart(Cart Cart)
        {
            return CartRepository.DeleteCart(Cart);
        }
        public static bool ClearCart(List<Cart> carts)
        {
            return CartRepository.ClearCart(carts);
        }
    }
}