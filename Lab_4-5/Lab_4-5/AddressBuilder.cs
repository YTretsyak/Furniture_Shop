using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    class AddressBuilder
    {
        Address result = new Address();
        public void Reset()
        {
            result = new Address();
        }

        public void SetCountry(string s)
        {
            result.Country = s;
        }

        public void SetCity(string s)
        {
            result.City = s;
        }

        public void SetStreet(string s)
        {
            result.Street = s;
        }

        public void SetHouse(int a)
        {
            result.House = a;
        }

        public void SetApartmentNumber(int a)
        {
            result.ApartmentNumber = a;
        }

        public Address GetResult()
        {
            return result;
        }
    }
}
