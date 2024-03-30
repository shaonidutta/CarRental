using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentAPI.Models
{
    public class CarModel
    {
        

            [Required]
            public string Maker { get; set; }
            [Required]
            public string Model { get; set; }
            [Required]
            public float RentalPrice { get; set; }
            [Required]
            public string Img { get; set; }


        
    }
}
