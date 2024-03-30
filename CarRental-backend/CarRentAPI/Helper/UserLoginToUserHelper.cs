using CarRentAPI.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentAPI.Helper
{
    public class UserLoginToUserHelper
    {
        public User UserLoginToUserMapping(UserLogin e)
        {
            User u = new User();
            u.EmailId = e.EmailId;
            u.Password = e.Password;
            return u;
        }
    }
}
