using balaitani_psd.Handler;
using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Controller
{
    public class PaymentMethodController
    {
        public static List<PaymentMethod> GetAllPaymentMethods()
        {
            return PaymentMethodHandler.GetAllPaymentMethods();
        }
    }
}