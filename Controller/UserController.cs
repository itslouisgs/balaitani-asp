using balaitani_psd.Factory;
using balaitani_psd.Handler;
using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Controller
{
    public class UserController
    {
        public static User GetUser(string email, string password)
        {
            return UserHandler.GetUser(email, password);
        }
        public static string RegisterUser(string name, string email, string password, string address)
        {
            if (name.Length < 1 || email.Length < 1 || password.Length < 1 || address.Length < 1)
            {
                return "All fields must be filled!";
            }


            User user = UserFactory.Create(name, email, password, address);
            UserHandler.RegisterUser(user);
            return "Register success";
        }
    }
}