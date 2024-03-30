using CarRentAPI.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentAPI.Helper
{
    public class RentCarToRentHelper
    {
        public Rent RentCarToRentMapping(RentCar e)
        {
            Rent c = new Rent();
            c.CarId = e.CarId;
            c.UserId = e.UserId;
            c.RentedPrice = e.RentedPrice;
            c.StartDate = e.StartDate;
            c.EndDate = e.EndDate;

            return c;
        }
    }
}
