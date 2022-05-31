using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateHeader(int user_id, int payment_method_id, int shipping_id)
        {
            TransactionHeader newHeader = new TransactionHeader
            {
                user_id = user_id,
                payment_method_id = payment_method_id,
                shipping_id = shipping_id,
                status = "pending",
                transaction_date = DateTime.Now
            };

            return newHeader;
        }

        public static TransactionDetail CreateDetail(int transaction_id, int product_id, int quantity)
        {
            TransactionDetail newDetail = new TransactionDetail
            {
                transaction_id = transaction_id,
                product_id = product_id,
                quantity = quantity
            };

            return newDetail;
        }
    }
}