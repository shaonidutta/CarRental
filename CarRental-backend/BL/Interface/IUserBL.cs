using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Interface
{
    public interface IUserBL
    {
        public User UserExists(User user);
        public bool AddUser(User user);
    }
}
