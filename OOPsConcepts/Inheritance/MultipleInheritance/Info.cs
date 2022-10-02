using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Inheritance.MultipleInheritance
{
    public class Info:Car,Engine
    {
        public string On()
        {
            return "Car is ON";
        }

        public string Start()
        {
            return "Engine is STARTED";
        }
    }
}
