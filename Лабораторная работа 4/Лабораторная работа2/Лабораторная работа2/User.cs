using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа2
{
    class User
    {
        public Color FontColor { get; set; }
        public Font FontType { get; set; }
    }

    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        private User config;

        private Singleton()
        {
            Config = new User
            {
                FontColor = Color.SkyBlue,
                FontType = new Font("Arial", 9.0f)
            };
        }

        internal User Config { get => config; set => config = value; }

        public static Singleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
