using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IRentDAL
    {
        public bool RentCar(Rent car);
        public bool EditRent(Rent val);
        public bool DeleteRent(int id,int uId);
        public bool IsAvailable(int cId);
        public IEnumerable<Object> MyRentalAggrements(int uId);
        public IEnumerable<Object> AllRentalAggrements();
        public Object MyOneRentalAggrements(int id);

    }
}
