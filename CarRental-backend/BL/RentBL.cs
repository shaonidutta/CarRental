using BL.Interface;
using DAL.Interface;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class RentBL:IRentBL
    {
        private readonly IRentDAL _rentDal;

        public RentBL(IRentDAL rentDal)
        {
            _rentDal = rentDal;
        }

        public bool RentCar( Rent car)
        {

            return _rentDal.RentCar(car);
        }

        public bool EditRent(Rent val)
        {
            var p = _rentDal.EditRent(val);
            return p;
        }
        public bool DeleteRent(int val ,int uId)
        {
            var p = _rentDal.DeleteRent(val,uId);
            return p;
        }

        public bool IsAvailable(int cId)
        {
            return _rentDal.IsAvailable(cId);
        }

        public IEnumerable<Object> MyRentalAggrements(int id)
        {
            var uId = id;
            return _rentDal.MyRentalAggrements(uId);
        }
        public IEnumerable<Object> AllRentalAggrements()
        {

            return _rentDal.AllRentalAggrements();
        }
        public Object MyOneRentalAggrements(int id)
        {
            var rId = id;
            return _rentDal.MyOneRentalAggrements(rId);
        }
    }
}
