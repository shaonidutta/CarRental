using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Interface
{
    public interface IRentBL
    {
        public bool RentCar(Rent car);
        public bool EditRent(Rent val);
        public bool DeleteRent(int val,int uId);
        public bool IsAvailable(int cId);
        public IEnumerable<Object> MyRentalAggrements(int id);
        public IEnumerable<Object> AllRentalAggrements();
        public Object MyOneRentalAggrements(int id);
    }
}
