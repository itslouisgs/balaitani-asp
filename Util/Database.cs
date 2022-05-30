using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Util
{
    public class Database
    {
        private static MainDatabaseEntities db = null;
        public static MainDatabaseEntities GetDatabase()
        {
            if(db == null)
            {
                db = new MainDatabaseEntities();
            }
            return db;
        }
    }
}