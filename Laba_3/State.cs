using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Laba_3
{
    public interface IUserConfig 
    {
        Color BG { get; }
        Font FontType { get; }
        int FontSize { get; }
    }
}
