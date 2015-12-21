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
        public string StoreName { get; set; }
        public int TotalSupply { get; set; }
        public int AvailableSupply { get; set; }
        public List<int> RentalHistoryIDs { get; set; }
    }

   
}