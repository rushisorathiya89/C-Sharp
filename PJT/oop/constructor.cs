using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.oop
{
    internal class constructor
    {
        class Employee
        {
            int empid;
            string name;
            string city;
            public Employee()
            {

            }
            public Employee(int empid,string name)
            {
                this.empid = empid;
                this.name = name;
            }
            public Employee(int empid,string name,string city)
            {
                this.city = city;
            }

            public void Display()
            {
                Console.WriteLine("the id is :" +  empid);
                Console.WriteLine("the name is : " + name);
                Console.WriteLine("the city is : " + city);
            }
        }
        static void Main(string[] args)
        {
          Employee emp = new Employee(1,"rushi");
            emp.Display();

        }
    }
}