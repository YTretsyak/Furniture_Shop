using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    public sealed class Singleton
    {
        public static Singleton Instance;
        private Singleton()
        {

        }
        public static Singleton GetInstance()
        {
            return Instance ?? (Instance = new Singleton());
        }
    }
}
