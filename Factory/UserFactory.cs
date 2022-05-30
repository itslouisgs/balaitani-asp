using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace balaitani_psd.Factory
{
    public class UserFactory
    {
        public static User Create(string name, string email, string password, string address)
        {
            User newUser = new User
            {
                name = name,
                email = email,
                password = password,
                address = address,
                role = "user"
            };

            return newUser;
        }
    }
}