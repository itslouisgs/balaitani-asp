using balaitani_psd.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Controller
{
    public class UserController
    {
        public static User GetUser(string username, string password)
        {
            return UserHandler.GetUser(username, password);
        }
    }
}