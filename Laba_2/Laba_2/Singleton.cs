using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    class Singleton
    {
        private static readonly Lazy<Singleton> singleton = new Lazy<Singleton>(()=> new Singleton());
        public string font { get; private set; }
        public string fontSize { get; private set; }
        public string bgColor { get; private set; }

        private Singleton()
        {
            font = Form1.DefaultFont.Name;
            fontSize = Form1.DefaultFont.Size.ToString();
            bgColor = Form1.DefaultBackColor.ToString();
        }

        public static Singleton GetSingleton()
        {
            return singleton.Value;
        }
    }
}
