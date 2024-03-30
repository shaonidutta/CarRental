using DAL.Interface;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
     public class CarDAL:ICarDAL
    {
        private readonly CarRentContext _context;

        public CarDAL(CarRentContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<Car> GetAllCars()
        {
            IEnumerable<Car> cars = _context.Cars.ToList();
            return cars;
        }

        public IEnumerable<Car> GetFilteredCars(Car c)
        {
            IEnumerable<Car> query = _context.Cars.ToList();
            IEnumerable<Car> ele;
            if (c.RentalPrice<0)
            {
                 ele = from u in query
                          where u.Model.Contains(c.Model) && u.Maker.Contains(c.Maker)
                          select u;
            }
            else
            {
                 ele = from u in query
                          where u.Model.Contains(c.Model) && u.Maker.Contains(c.Maker) && u.RentalPrice.Equals(c.RentalPrice)
                          select u;
            }
           
            return ele;

        }

        public Car GetACarById(int id)
        {
            var car = (from c in _context.Cars where c.CarId == id select c).ToList().FirstOrDefault();
            return car;
        }
        public bool AddCar(Car v)
        {
            try
            {

                _context.Cars.Add(v);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public bool DeleteCar(int cid)
        {
            var query = from c in _context.Cars
                        where c.CarId == cid
                        select c;

            var car = query.ToList().FirstOrDefault();


            if (car != null)
            {
                _context.Cars.Remove(car);
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
