using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Inheritance.HeirarchicalInheritance
{
    public class Bike:Vehical
    {
        public void BikeInfo()
        {
            string vehical = "Bike";
            int price = 90000;
            Console.WriteLine(Type(vehical));
            Console.WriteLine(Value(price, vehical)); 

        }
    }
}
