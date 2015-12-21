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
        //public virtual ICollection<Inventory>

        //inventory goes to one car, car can have many inventories
        //location class
        //we have 10 explorers at location 5
        //when a user logs in, they're associated with a store
        //We can just say user 5 is from branch 2
        //Application User => User
        //Location will have a list of users

    }
}