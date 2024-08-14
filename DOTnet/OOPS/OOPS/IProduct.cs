using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal interface IProduct
    {
        string ProductName { get; set; }

        string ProductPrice { get; set; }

        string ProductCategory { get; set; }

        void getProductDetials(); 

    }

}
