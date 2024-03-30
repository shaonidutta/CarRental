using CarRentAPI.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentAPI.Helper
{
    public class UserModelToUserHelper
    {
        public User UserModelToUserMapping(UserModel e)
        {
            User u = new User();
            u.Name = e.Name;
            u.PhNum = e.PhNum;
            u.EmailId = e.EmailId;
            u.Password = e.Password;
            return u;
        }
    }
}
