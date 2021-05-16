using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_5
{
    interface IAccommodationFactory
    {
        Accommodation CreateAccommodation(Form1 form);
    }
}
