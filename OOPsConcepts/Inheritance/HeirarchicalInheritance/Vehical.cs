using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Inheritance.HeirarchicalInheritance
{
    public class Vehical
    {
        public string Type(string vehical)
        {
            return vehical + " is on.";
        }
        public string Value(int price,string vehical)
        {
            return "Price of " + vehical + " is " + price;
        }
    }
}
