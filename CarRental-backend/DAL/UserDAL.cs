﻿using DAL.Interface;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   
        public class UserDAL : IUserDAL
        {
            private readonly CarRentContext _context;

            public UserDAL(CarRentContext dbContext)
            {
                _context = dbContext;
            }



        public IEnumerable<User> GetUsers()
        {
            IEnumerable<User> users = _context.Users.ToList();
            return users;
        }

        public User UserExists(User user)
            {
                var query = (_context.Users.FirstOrDefault(u => u.EmailId == user.EmailId && u.Password==user.Password));

                if (query != null)
                {
                    User userDal = query;
                    return userDal;
                }
                return null;
            }

        public bool AddUser(User user)
        {
            IEnumerable<User> users = GetUsers();
            int count = (from u in users
                         where (u.EmailId == user.EmailId)
                         select u).ToList().Count();
            if (count == 0)
            {
                user.Isadmin = false;
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }



    }

    }

