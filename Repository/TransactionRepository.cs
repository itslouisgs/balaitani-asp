using balaitani_psd.Model;
using balaitani_psd.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Repository
{
    public class TransactionRepository
    {
        private static MainDatabaseEntities db = Database.GetDatabase();
        public static TransactionHeader AddTransactionHeader(TransactionHeader transactionHeader)
        {
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();

            return transactionHeader;
        }

        public static List<TransactionDetail> AddTransactionDetails(List<TransactionDetail> transactionDetails)
        {
            db.TransactionDetails.AddRange(transactionDetails);
            db.SaveChanges();

            return transactionDetails;
        }

        public static List<TransactionHeader> GetAllTransactions()
        {
            return db.TransactionHeaders.ToList();
        }

        public static TransactionHeader GetTransactionById(int id)
        {
            return db.TransactionHeaders.Find(id);
        }
    }
}