using CarRentAPI.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentAPI.Helper
{
    public class CarModelToCarHelper
    {
        public Car CarModelToCarMapping(CarModel e)
        {
            Car u = new Car();
            u.Maker = e.Maker;
            u.Model = e.Model;
            u.RentalPrice = e.RentalPrice;
            u.Img = e.Img;
            return u;
        }

    }
}
