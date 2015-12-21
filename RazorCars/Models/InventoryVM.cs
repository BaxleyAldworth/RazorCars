using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCars.Models
{
    //[Json(Title = "Invetory")]
    public class InventoryVM
    {
        public string CarName { get; set; }
        public int Store { get; set; }
        public int TotalSupply { get; set; }
        public bool IsAvailable { get; set; }
        public List<int> RentalHistoryIDs { get; set; }
    }
}