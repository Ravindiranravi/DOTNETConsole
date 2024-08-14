using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal interface IOutlet
    {
        string OutletName { get; set; }

        string Outletcity { get; set; }

        string OutletLocation { get; set; }

        void OutletDetials();

    }
}
