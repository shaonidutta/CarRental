using DAL.Interface;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class RentDAL:IRentDAL
    {
        private readonly CarRentContext _context;

        public RentDAL(CarRentContext dbContext)
        {
            _context = dbContext;
        }
        public bool RentCar(Rent car)
        {
            try
            {
                var query = from rent in _context.Rents 
                            where rent.CarId == car.CarId 
                            select rent;
                //var c = query.ToList().FirstOrDefault();
                //if (c != null)
                //{
                    
                //    if (car.StartDate <= c.EndDate)
                //    {
                //        return false;
                //    }
                //    else
                //    {
                //        car.IsAccepted = false;
                //        car.IsReturned = false;
                //        car.ReturnReq = false;
                //        _context.Rents.Add(car);
                //        _context.SaveChanges();
                //        return true;
                //    }
                //}

                foreach(var r in query)
                {
                    if (r.IsAccepted == true&& r.IsReturned==false)
                    {
                        return false;
                    }
                }
                //else
                //{
                    car.IsAccepted = false;
                    car.IsReturned = false;
                    car.ReturnReq = false;
                    _context.Rents.Add(car);
                    _context.SaveChanges();
                    return true;
                //}
            
            }
            catch(Exception ex) { 
            }

            return false;
           
        }


        public bool EditRent(Rent val)
        {
            try
            {
                _context.Rents.Update(val);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
            }
            return false;
            
        }
        public bool DeleteRent(int id, int uId)
        {
            var query = from r in _context.Rents
                        where r.RentId == id
                        select r;

            var rnt = query.ToList().FirstOrDefault();

            var u = (from us in _context.Users where us.UserId == uId select us).ToList().FirstOrDefault();

            if (rnt != null&& (u.Isadmin==true||rnt.IsAccepted==false))
            {   
                _context.Rents.Remove(rnt);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        //available
        public bool IsAvailable(int cId)
        {
            var query = from rent in _context.Rents
                        where rent.CarId == cId
                        select rent;

            foreach (var r in query)
            {
                if (r.IsAccepted == true && r.IsReturned == false)
                {
                    return false;
                }
            }
            return true;
        }

        //myrentalagreements
        public IEnumerable<Object> MyRentalAggrements(int uId)
        {
            var query = (from r in _context.Rents
                         join c in _context.Cars
                          on r.CarId equals c.CarId
                         where r.UserId == uId
                         select new { c.CarId, c.Maker, c.Model, c.RentalPrice, c.Img, r.RentId, r.StartDate,r.RentedPrice,r.EndDate, r.ReturnReq, r.IsReturned, r.IsAccepted }).ToList();
            return query;

        }

        public IEnumerable<Object> AllRentalAggrements()
        {
            var query = (from r in _context.Rents
                         join c in _context.Cars
                          on r.CarId equals c.CarId
                         join u in _context.Users
                         on r.UserId equals u.UserId
                         select new
                         {
                             c.CarId,
                             c.Maker,
                             c.Model,
                             c.RentalPrice,
                             c.Img,
                             r.RentId,
                             r.StartDate,
                             r.EndDate,
                             r.RentedPrice,
                             r.ReturnReq,
                             r.IsReturned,
                             r.IsAccepted,
                             u.UserId,
                             u.Name,
                             u.PhNum,
                             u.EmailId
                         }).ToList();

            return query;
        }

        public Object MyOneRentalAggrements(int id)
        {
            var query = (from r in _context.Rents
                         join c in _context.Cars
                          on r.CarId equals c.CarId
                         where r.RentId == id
                         select new { c.CarId, c.Maker, c.Model, c.RentalPrice, c.Img,r.UserId, r.RentId, r.StartDate, r.EndDate, r.RentedPrice, r.ReturnReq, r.IsReturned, r.IsAccepted }).ToList();
            return query.ToList().FirstOrDefault();
        }
    }
}
