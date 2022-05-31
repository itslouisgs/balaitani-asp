using balaitani_psd.Factory;
using balaitani_psd.Handler;
using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Controller
{
    public class TransactionController
    {
        public static bool Checkout(int user_id, List<Cart> carts, int payment_method_id, int shipping_id)
        {
            TransactionHeader header = TransactionHandler.AddTransactionHeader(TransactionFactory.CreateHeader(user_id, payment_method_id, shipping_id));

            List<TransactionDetail> details = new List<TransactionDetail>();
            foreach(Cart c in carts)
            {
                details.Add(TransactionFactory.CreateDetail(header.id, c.product_id, c.quantity));
            }
            TransactionHandler.AddTransactionDetails(details);

            CartHandler.ClearCart(carts);
            return true;
        }
        public static TransactionHeader GetTransactionById(int id)
        {
            return TransactionHandler.GetTransactionById(id);
        }
    }
}