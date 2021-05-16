using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    interface IDeSerealization<T>
    {
        List<T> Deserializing(string path);
        void Serializing(T obj, string path);
    }
}
