using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFactory
    {
        public static Customer Randomize()
        {
            Customer customer = new Customer();
            customer.FullName = "Name";
            customer.Address = "info";

            return customer;
        }
    }
}
