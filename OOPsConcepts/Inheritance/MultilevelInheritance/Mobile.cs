using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Inheritance.MultilevelInheritance
{
    public class Mobile:Electronics
    {
        public string Mob(string company,string electronic,string Mobname)
        {
            Console.WriteLine(Type(company, electronic)); 
            return "Mobile: "+Mobname;
        }
    }
}
