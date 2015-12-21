using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCars.Models
{
    public class Inventory
    {
        public Inventory()
        {
            Histories = new List<RentalHistory>();
        }
        public int ID { get; set; }
        public int TotalSupply { get; set; }
        public virtual Car CarType { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<RentalHistory> Histories { get; set; }
    }
}