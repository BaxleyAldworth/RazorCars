using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCars.Models
{
    [JsonObject(Title = "Inventory")]
    public class RentalHistory
    {
        public int ID { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime? CheckInDate { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}