using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal interface IAddress { 
    string addressline1 { get; set; }

    string city { get; set; }

    string state { get; set; }

    int pincode { get; set; }

    void getaddress();
    }


}
