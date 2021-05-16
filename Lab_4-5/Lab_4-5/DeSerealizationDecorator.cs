using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    class DeSerealizationDecorator : IDeSerealization<Apartment>
    {
        public Apartment wrapper;
        public DeSerealizationDecorator(Apartment component)
        {
            wrapper = component;
        }
        public List<Apartment> Deserializing(string path)
        {
            return wrapper.Deserializing(path);
        }

        public void Serializing(Apartment obj, string path)
        {
            wrapper.Serializing(obj, path);
        }
    }
}
