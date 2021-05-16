using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    interface IAccommodationBuilder
    {
        void Reset();
        void SetArea(int a);
        void SetNumberOfRooms(int a);
        void SetAvailability(string s);
        void SetMaterial(string s);
        void SetYearOfConstruction(int a);
        void SetFloor(int a);
        void SetAddress(Address a);
    }
}
