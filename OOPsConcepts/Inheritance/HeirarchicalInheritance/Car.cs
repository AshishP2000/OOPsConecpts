using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Inheritance.HeirarchicalInheritance
{
    public class Car:Vehical
    {
        public void CarInfo()
        {
            string vehical = "Car";
            int price = 1700000;
            Console.WriteLine(Type(vehical));
            Console.WriteLine(Value(price, vehical)); 
            
        }
    }
}
