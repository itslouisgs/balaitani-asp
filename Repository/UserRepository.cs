using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Repository
{
    public class UserRepository
    {
        private static MainDatabaseEntities db = new MainDatabaseEntities();

        public static User GetUser(string username, string password)
        {
            return (from x in db.Users
                    where x.email == username && x.password == password
                    select x).FirstOrDefault();
        }
    }
}