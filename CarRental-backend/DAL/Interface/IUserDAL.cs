using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
     public interface IUserDAL
    {
        public User UserExists(User user);
        public bool AddUser(User user);
    }
}
