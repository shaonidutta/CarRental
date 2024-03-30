using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    public class Car
    {
        public int CarId { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public float RentalPrice { get; set; }
        public string Img { get; set; }

        [ForeignKey("CarId")]
        public ICollection<Rent> Rents { get; set; }
    }
}
