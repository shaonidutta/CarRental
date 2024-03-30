using CarRentAPI.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentAPI.Helper
{
    public class FilterCarToCarHelper
    {
        public Car FilterCarToCarMapping(FilterCar e)
        {
            Car u = new Car();
            u.Maker  = e.Maker;
            u.Model = e.Model;
            u.RentalPrice = e.RentalPrice;

            return u;
        }
    }
}
