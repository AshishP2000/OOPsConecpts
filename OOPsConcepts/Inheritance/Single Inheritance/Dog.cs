using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Inheritance.Single_Inheritance
{
    public class Dog:Animal
    {
        public void Info()
        {
            Console.WriteLine(Eat("Dog"));
        }
    }
}
