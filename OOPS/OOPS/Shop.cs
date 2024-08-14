using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Shop : IProduct, IOutlet
    {
        public string Shopname { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public string OutletName { get; set; }
        public string Outletcity { get; set; }
        public string OutletLocation { get; set; }

        public void getProductDetials()
        {
            Console.WriteLine("Product Name: " + this.ProductName);
            Console.WriteLine("Product Price: " + this.ProductPrice );
            Console.WriteLine("Product Category: " + this.ProductCategory);
        }

        public void OutletDetials()
        {
            Console.WriteLine("Outle tName: " + this.OutletName);
            Console.WriteLine("Outlet city: " + this.Outletcity);
            Console.WriteLine("Outlet Location: " + this.OutletLocation);

        }
    }
}
