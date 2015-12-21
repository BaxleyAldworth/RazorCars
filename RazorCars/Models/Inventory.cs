using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCars.Models
{
    public class Inventory
    {
        public int TotalSupply { get; set; }
        public int AvailableForRent { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool IsReturn { get; set; }
        public virtual Car CarType { get; set; }
    }
}