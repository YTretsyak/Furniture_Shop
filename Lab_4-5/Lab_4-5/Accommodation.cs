using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    [Serializable]
    abstract class Accommodation : IAccommodationPrototype
    {
        public int Area { get; set; }
        public int NumberOfRooms { get; set; }
        public string Availability = "none";
        public string Material { get; set; }
        public int YearOfConstruction { get; set; }
        public int Floor { get; set; }
        public Address Address { get; set; }

        abstract public Accommodation clone();
    }
}
