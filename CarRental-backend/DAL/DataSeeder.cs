using Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class DataSeeder
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var seerviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = seerviceScope.ServiceProvider.GetService<CarRentContext>();
                if (!context.Users.Any())
                {

                    var users = new List<User>
                {
                new User {Name="admin1", EmailId = "admin1@gmail.com",PhNum="1234567899", Password = "P@ssword1", Isadmin=true },
                new User {Name="admin2", EmailId = "admin2@gmail.com",PhNum="1234567898", Password = "P@ssword2", Isadmin=true},
                new User {Name="Shaoni", EmailId = "shaoni@gmail.com",PhNum="1234567898", Password = "P@ss", Isadmin=false},
                new User {Name="test1", EmailId = "test1@gmail.com",PhNum="1234567898", Password = "P@ss1", Isadmin=false},
                new User {Name="test2", EmailId = "test2@gmail.com",PhNum="1234567898", Password = "P@ss2", Isadmin=false}

                };

                    context.Users.AddRange(users);
                    context.SaveChanges();
                }
                if (!context.Cars.Any())
                {

                 var cars = new List<Car>
                {
                new Car {Maker="Toyota", Model = "Camry",RentalPrice=50 ,Img = "https://th.bing.com/th/id/OIP.D1IKa-VRySSxcWzqquI8WwHaE8?pid=ImgDet&w=474&h=316&rs=1" },
                new Car {Maker="Ford", Model = "Focus",RentalPrice= 45, Img = "https://www.pixelstalk.net/wp-content/uploads/2016/08/Free-Cars-Full-HD-Images-1080p.jpg"},
                new Car {Maker="Chevrolet", Model = "Malibu",RentalPrice= 55, Img = "https://www.wrapstyle.com/content/img_cache/1920x/1593005515-Ford-Focus-rs-Red2.jpg"},
                new Car {Maker="Honda", Model = "Civic",RentalPrice= 48, Img = "https://th.bing.com/th/id/OIP.ir-QE1HtVGvZmajG2CFviQHaEs?pid=ImgDet&rs=1"}

                };

                    context.Cars.AddRange(cars);
                    context.SaveChanges();
                }
            }
        }
    }

}
