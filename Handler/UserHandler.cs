using balaitani_psd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Handler
{
    public class UserHandler
    {
        public static User GetUser(string username, string password)
        {
            return UserRepository.GetUser(username, password);
        }
    }
}