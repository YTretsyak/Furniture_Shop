using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_3
{
    public class WhiteTheme : IUserConfig
    {
        public Color BG => Color.White;
        public Font FontType => new Font("Arial", 10.0f);
        public int FontSize => 12;
    }
    public class BlackTheme : IUserConfig
    {
        public Color BG => Color.DimGray;
        public Font FontType => new Font("Arial", 10.0f);
        public int FontSize => 12;
    }

    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public IUserConfig IuConfig;

        private Singleton()
        {
            IuConfig = new WhiteTheme();
        }

        public static void ChangeTheme(IUserConfig iuconfig)
        {
            lazy.Value.IuConfig = iuconfig;
        }

        public static Singleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
