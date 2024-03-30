using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentAPI.Models;
using Shared;
using BL.Interface;
using CarRentAPI.Helper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserBL _userBl;

        public UserController(IUserBL userBl)
        {
            _userBl = userBl;
        }





        // POST api/<UserController>
        [HttpPost]
        [Route("login/post")]
        public Object Post( UserLogin val)
        {
            if (ModelState.IsValid)
            {
                User user = new UserLoginToUserHelper().UserLoginToUserMapping(val);
                var userdummy = _userBl.UserExists(user);
                if (userdummy != null)
                {
                    return userdummy;
                }
                else
                    return null;
            }

            return null;
           
        }



        [HttpPost]
        [Route("register/post")]
        public bool Post([FromBody] UserModel val)
        {
            if (val != null)
            {
                User user = new UserModelToUserHelper().UserModelToUserMapping(val);
                if (ModelState.IsValid)
                {
                    if (_userBl.AddUser(user))
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

       


    }
}
