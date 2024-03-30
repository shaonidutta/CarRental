using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    public class Rent
    {
        public int RentId { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car _car { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float RentedPrice { get; set; }
        public bool ReturnReq { get; set; }
        public bool IsReturned { get; set; }
        public bool IsAccepted { get; set; }


    }
}
