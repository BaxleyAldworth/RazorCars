using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCars.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string ModelYear { get; set; }
        public string Manufacturer { get; set;  }
        public string Model { get; set; }
    }
}