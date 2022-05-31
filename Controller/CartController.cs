using balaitani_psd.Factory;
using balaitani_psd.Handler;
using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Controller
{
    public class CartController
    {
        public static string AddCart(User user, Product product, int quantity) 
        {
            if (quantity < 1 || quantity > product.stock)
            {
                return "Quantity must be between 1 and " + product.stock;
            }

            Cart cart = user.Carts.Where(c => c.product_id == product.id).FirstOrDefault();
            if (cart != null)
            {
                cart.quantity = quantity;
                CartHandler.UpdateCart(cart);
            }else
            {
                cart = CartFactory.Create(user.id, product.id, quantity);
                CartHandler.AddCart(cart);
            }

            return "Cart added successfully";
        }

        public static void DeleteCart(Cart cart)
        {
            CartHandler.DeleteCart(cart);
        }

        public static void UpdateCart(Cart cart, int quantity)
        {
            if(quantity < 0 || quantity > cart.Product.stock)
            {
                return;
            }
            cart.quantity = quantity;
            CartHandler.UpdateCart(cart);
        }
    }
}