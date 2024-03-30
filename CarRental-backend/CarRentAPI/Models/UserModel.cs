using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentAPI.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhNum { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool Isadmin { get; set; }
    }
}
