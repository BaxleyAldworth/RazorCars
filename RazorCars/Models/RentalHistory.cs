using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCars.Models
{
    public class RentalHistory
    {
        public int ID { get; set; }
        public int TotalSupply { get; set; }
        public int AvailableForRent { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool IsReturned { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}