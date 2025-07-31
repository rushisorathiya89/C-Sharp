using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.oop
{
    internal class Methodoverloading
    {
        /// <summary>
        /// Method Overloading
        /// ->it is a one type of polymorphimsum.
        /// ->must have same name.
        /// ->must be different with parameters *number of parameters or types of parameters (for same no. of parameters)
        /// ->Return type does note play any role
        /// </summary>
        class Overloading
        {
            public void sum(int a, int b)
            {
                Console.WriteLine("Sum of two integers: " + (a + b));
            }
            public void sum(double a, double b,double c)
            {
                Console.WriteLine("Sum of two doubles: " + (a + b+ c ));
            }
            public void sum(int a, int b, int c)
            {
                Console.WriteLine("Sum of three integers: " + (a + b + c));
            }
        }
        static void Main(string[] args)
        {
            Overloading obj = new Overloading();
            obj.sum(10, 20);          // Calls the first method
            obj.sum(10.5, 20.5, 30.5); // Calls the second method
            obj.sum(10, 20, 30);      // Calls the third method
        }
    }
}
