using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Company: IAddress,IContact
    {
      public string Name { get; set; }
       public string addressline1 { get; set; }
      public string city { get; set; }
      public string state { get; set; }
      public  int pincode { get; set; }
      public  string email { get; set; }
     public long  mobile { get; set; }


        public void getaddress()
        {
            Console.WriteLine("Company Name: " + this.Name);
            Console.WriteLine("Address Line 1: " + this.addressline1 + "\n" + "City: " + this.city +
                "\n" + "State: " + this.state + "\n" + "PostCode: " + this.pincode);
        }

        public void getcontact()
        {
            Console.WriteLine("Email: " + this.email + "\n" + "Mobile Number:" + this.mobile);
        }

    }
}
