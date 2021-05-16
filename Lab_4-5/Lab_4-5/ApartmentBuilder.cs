using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    class ApartmentBuilder : IAccommodationBuilder
    {
        Apartment result = new Apartment();
        public void Reset()
        {
            result = new Apartment();
        }
        public void SetAddress(Address a)
        {
            result.Address = a;
        }

        public void SetFloor(int a)
        {
            result.Floor = a;
        }

        public void SetArea(int a)
        {
            result.Area = a;
        }

        public void SetAvailability(string s)
        {
            result.Availability = s;
        }

        public void SetMaterial(string s)
        {
            result.Material = s;
        }

        public void SetNumberOfRooms(int a)
        {
            result.NumberOfRooms = a;
        }

        public void SetYearOfConstruction(int a)
        {
            result.YearOfConstruction = a;
        }

        public Apartment GetResult()
        {
            return result;
        }
    }
}
