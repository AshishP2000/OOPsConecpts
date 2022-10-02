using OOPsConcepts.Inheritance.HeirarchicalInheritance;
using OOPsConcepts.Inheritance.MultilevelInheritance;
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
            //Multilevel Inheritance
            Mobile mobile = new Mobile();//creating object of class
            Console.WriteLine(mobile.Mob("Samsung", "Mobiles", "Samsung Galaxy s22")); //calling method using object car
            
            Console.ReadLine();
        }
    }
}
