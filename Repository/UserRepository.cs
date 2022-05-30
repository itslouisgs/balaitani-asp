using balaitani_psd.Model;
using balaitani_psd.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace balaitani_psd.Repository
{
    public class UserRepository
    {
        private static User currentUser = null;

        private static MainDatabaseEntities db = Database.GetDatabase();

        public static User GetCurrentUser()
        {
            if(currentUser == null && HttpContext.Current.Session["user"] != null)
            {
                currentUser = (User)HttpContext.Current.Session["user"];
            }
            return currentUser;
        }

        public static User GetUser(string email, string password)
        {
            return (from x in db.Users
                    where x.email == email && x.password == password
                    select x).FirstOrDefault();
        }

        public static User RegisterUser(User user)
        {
            db.Users.Add(user);
            Debug.WriteLine(user);
            db.SaveChanges();

            return user;
        }
    }
}