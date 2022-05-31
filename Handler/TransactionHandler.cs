using balaitani_psd.Model;
using balaitani_psd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Handler
{
    public class TransactionHandler
    {
        public static TransactionHeader AddTransactionHeader(TransactionHeader transactionHeader)
        {
            return TransactionRepository.AddTransactionHeader(transactionHeader);
        }

        public static List<TransactionDetail> AddTransactionDetails(List<TransactionDetail> transactionDetails)
        {
            return TransactionRepository.AddTransactionDetails(transactionDetails);
        }
    }
}