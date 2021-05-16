using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab_4_5
{
    [Serializable]
    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int ApartmentNumber { get; set; }

        [JsonConstructorAttribute]
        public Address(string country, string city, string street, int house, int apartmentNumber)
        {
            Country = country;
            City = city;
            Street = street;
            House = house;
            ApartmentNumber = apartmentNumber;
        }
        public Address()
        {

        }
        public override string ToString()
        {
            return "ADDRESS\n" + "Country: " + Country + "; City: " + City + "; Street: " + Street + "; House: " + House + "; Apartment number: " + ApartmentNumber + "\n";
        }
    }
}
