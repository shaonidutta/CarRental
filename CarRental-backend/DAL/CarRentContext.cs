using Microsoft.EntityFrameworkCore;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public  class CarRentContext: DbContext
    {
        public CarRentContext(DbContextOptions<CarRentContext> options)
            : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}
