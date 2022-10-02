using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Inheritance.MultilevelInheritance
{
    public class Electronics:Company
    {
        public string Type(string company,string electronic)
        {
            Console.WriteLine(Name(company)); 
            return "Electronic type: "+electronic;
        }
    }
}
