using OOPsConcepts.Inheritance.HeirarchicalInheritance;
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
            //Heirarchical Inheritance
            Car car = new Car();//creating object of class
            car.CarInfo();//calling method using object car
            Bike bike = new Bike();
            bike.BikeInfo();
            Console.ReadLine();
        }
    }
}
