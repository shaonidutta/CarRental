using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface ICarDAL
    {
        public IEnumerable<Car> GetAllCars();
        public IEnumerable<Car> GetFilteredCars(Car c);
        public Car GetACarById(int id);
        public bool AddCar(Car v);
        public bool DeleteCar(int cid);
    }
}
