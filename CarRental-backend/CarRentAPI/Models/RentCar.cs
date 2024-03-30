using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentAPI.Models
{
    public class RentCar
    {
        public int UserId { get; set; }
        public int CarId { get; set; }

        public float RentedPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
