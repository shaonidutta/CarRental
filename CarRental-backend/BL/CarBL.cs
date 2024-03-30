using BL.Interface;
using DAL.Interface;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
     public class CarBL:ICarBL
    {
        private readonly ICarDAL _carDal;

        public CarBL(ICarDAL carDal)
        {
            _carDal = carDal;
        }

        public IEnumerable<Car> GetAllCars()
        {
            var c = _carDal.GetAllCars();
            if (c != null)
                return c;
            else
                return null;

        }

       

        public IEnumerable<Car> GetFilteredCars(Car c)
        {
            var cars = _carDal.GetFilteredCars(c);
           
                return cars;
        }

        public Car GetACarById(int id)
        {
            var c = _carDal.GetACarById(id);
            if (c != null)
                return c;
            else
                return null;

        }
        public bool AddCar(Car v)
        {
            return _carDal.AddCar(v);
        }

        public bool DeleteCar(int cid)
        {
            return _carDal.DeleteCar(cid);
        }


    }
}
