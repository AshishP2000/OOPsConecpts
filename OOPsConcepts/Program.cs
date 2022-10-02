using OOPsConcepts.Inheritance.HeirarchicalInheritance;
using OOPsConcepts.Inheritance.MultilevelInheritance;
using OOPsConcepts.Inheritance.MultipleInheritance;
using OOPsConcepts.Inheritance.Single_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiple Inheritance using Interface
            Info info = new Info();
            Console.WriteLine(info.On());
            Console.WriteLine(info.Start()); 
            
            Console.ReadLine();
        }
    }
}
