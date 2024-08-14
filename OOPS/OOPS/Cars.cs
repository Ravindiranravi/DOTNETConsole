using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class Cars
    {
        public string brand;
        public string series;

        public abstract string getDetails();
    }

    class Supra : Cars
    {
        public string specialfeatures;

        public override string getDetails()
        {
            return this.brand + "The drift model " + " " + this.series +" " +"The most selling series"+ " " + specialfeatures;
        }
    }
}
