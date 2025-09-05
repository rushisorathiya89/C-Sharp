using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_3
{
    class Car
    {
        private string brand;   // data member to store car brand
        private int speed;      // data member to store car speed

        // Task 3: Add few methods as public to work on defined data members

        // Method to set car details
        public void SetDetails(string b, int s)
        {
            brand = b;
            speed = s;
        }

        // Method to display car details
        public void ShowDetails()
        {
            Console.WriteLine("Car Brand: " + brand);
            Console.WriteLine("Car Speed: " + speed + " km/h");
        }

        // Method to increase speed
        public void IncreaseSpeed(int value)
        {
            speed += value; // logic to increase car speed
            Console.WriteLine(brand + " speed increased to " + speed + " km/h");
        }
    }
    internal class Q1
    {
        static void Main(string[] args)
        {
            // Task 5: Create at least two objects of Car class
            Car car1 = new Car();  // First object
            Car car2 = new Car();  // Second object

            // Setting details of first car
            car1.SetDetails("Tesla", 120);
            // Setting details of second car
            car2.SetDetails("BMW", 150);

            // Calling methods using objects
            Console.WriteLine("Details of Car 1:");
            car1.ShowDetails();
            car1.IncreaseSpeed(20);

            Console.WriteLine("\nDetails of Car 2:");
            car2.ShowDetails();
            car2.IncreaseSpeed(30);

        }
    }
}
