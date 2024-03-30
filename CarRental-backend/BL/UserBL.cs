using BL.Interface;
using DAL.Interface;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class UserBL : IUserBL
    {
        private readonly IUserDAL _userDal;

        public UserBL(IUserDAL userDal)
        {
            _userDal = userDal;
        }
        public User UserExists(User user)
        {
            var u = _userDal.UserExists(user);
            if (u != null)
                return u;
            else
                return null;

        }

        public bool AddUser(User user)
        {
            if (_userDal.AddUser(user))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public bool AddUser(UserShared user)
        //{
        //    if (_userDal.AddUser(user))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
