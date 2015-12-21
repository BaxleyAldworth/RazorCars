using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCars.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }

        public string Name { get; set; }

    }
}