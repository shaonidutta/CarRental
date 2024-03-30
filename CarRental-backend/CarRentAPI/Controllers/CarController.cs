using BL.Interface;
using CarRentAPI.Helper;
using CarRentAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {


        private readonly ICarBL _carBl;

        public CarController(ICarBL carBl)
        {
            _carBl = carBl;
        }
        // GET: api/<CarController>
        [HttpGet]
        [Route("getallcars")]
        public IEnumerable<Car> GetAllCars()
        {
            return _carBl.GetAllCars();
        }

        //get car by id
        [HttpGet("{id}")]
        [Route("getacarbyid/{id}")]
        public Car GetACarById(int id)
        {
            return _carBl.GetACarById(id);
        }

        [HttpPost]
        [Route("getfilteredcars")]
        public IEnumerable<Car> GetFilteredCars(FilterCar car)
        {
            Car c = new FilterCarToCarHelper().FilterCarToCarMapping(car);
            return _carBl.GetFilteredCars(c);
        }

        [HttpPost]
        [Route("addcar")]
        public bool AddCar([FromBody] CarModel value)
        {

            if (value != null)
            {
                Car v = new CarModelToCarHelper().CarModelToCarMapping(value);
                return _carBl.AddCar(v);
            }
            else
            {
                return false;
            }

        }

        [HttpDelete("{id}")]
        [Route("deletecarbyid/{id}")]
        public bool DeleteCar(int id)
        {
            return _carBl.DeleteCar(id);
        }

       
    }
}
