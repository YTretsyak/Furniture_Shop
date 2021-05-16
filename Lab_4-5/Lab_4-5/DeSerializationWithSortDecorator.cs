using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    class DeSerializationWithSortDecorator : DeSerealizationDecorator
    {
        public DeSerializationWithSortDecorator(Apartment apartment) : base(apartment)
        {

        }
        /*public override List<Apartment> Deserializing(string path)
        {
           return base.Deserializing(path).OrderByDescending(i => i.Area).ThenBy(i => i.NumberOfRooms).ToList<Apartment>();
        }*/
    }
}
