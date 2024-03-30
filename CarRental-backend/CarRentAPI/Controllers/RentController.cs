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
    public class RentController : ControllerBase
    {
        private readonly IRentBL _rentBl;

        public RentController(IRentBL rentBl)
        {
            _rentBl = rentBl;
        }

        [HttpPost]
        [Route("rentcar")]
        public bool RentCar([FromBody] RentCar car )
        {
            Rent c = new RentCarToRentHelper().RentCarToRentMapping(car);

          //  var s = DateTime.Now;
            return _rentBl.RentCar(c);
          
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        [Route("editrent/{id}")]
        public bool EditRent(int id, [FromBody] Rent value)
        {
            if (value != null)
            {
               
                value.RentId = id;
                if (_rentBl.EditRent(value))
                {
                    return true;
                }
                else
                    return false;
            }

            return false;
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}/{uid}")]
        [Route("deleterent/{id}/{uid}")]
        public bool DeleteRent(int id,int uid)
        {
            int uId = uid;
            return _rentBl.DeleteRent(id,uId);

        }

        //available
        [HttpGet("{id}")]
        [Route("isavailable/{id}")]
        public bool IsAvailable(int id)
        {
            return _rentBl.IsAvailable(id);
        }

        [HttpGet("{id}")]
        [Route("myrentalaggrements/{id}")]
        public IEnumerable<Object> MyRentalAggrements(int id)
        {
            var uId = id;
            return _rentBl.MyRentalAggrements(uId);
        }

        [HttpGet]
        [Route("AllRentalAggrements")]
        public IEnumerable<Object> AllRentalAggrements()
        {

            return _rentBl.AllRentalAggrements();
        }

        [HttpGet("{id}")]
        [Route("myonerentalaggrements/{id}")]
        public Object MyOneRentalAggrements(int id)
        {
            var rId = id;
            return _rentBl.MyOneRentalAggrements(rId);
        }
      
    }
}
