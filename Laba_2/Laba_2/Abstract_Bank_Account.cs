using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    abstract class Abstract_Bank_Account
    {
        public string number { get; set; }
        public string deposit_Type { get; set; }
        public string balance { get; set; }
        public string opening_Date { get; set; }
        public bool SMS_notification { get; set; }
        public bool internet_Banking { get; set; }
        public IOwner Owner { get; set; }

        abstract public Abstract_Bank_Account clone();
    }
}
