using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCars.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}