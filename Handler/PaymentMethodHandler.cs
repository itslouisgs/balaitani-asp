using balaitani_psd.Model;
using balaitani_psd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Handler
{
    public class PaymentMethodHandler
    {
        public static List<PaymentMethod> GetAllPaymentMethods()
        {
            return PaymentMethodRepository.GetAllPaymentMethods();
        }
    }
}