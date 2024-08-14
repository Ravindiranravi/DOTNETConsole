using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal interface IContact
    {
        string email { get; set; }      

        long mobile { get; set; }

       void getcontact();
    }
}
