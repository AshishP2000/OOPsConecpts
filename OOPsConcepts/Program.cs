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
            //Single Inheritance
            Dog dog = new Dog();//creating object of class
            dog.Info();//calling method using object dog
            Console.ReadLine();
        }
    }
}
