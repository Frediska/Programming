using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class AddressFactory
    {
        public static Address Randomize()
        {
            Address address = new Address();

            address.City = "None";
            address.Street = "None";
            address.Apartment = "None";
            address.Building = "None";
            address.Country = "None";
            address.Index = 100000;

            return address;
        }
    }
}
