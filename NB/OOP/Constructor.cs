using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    /*
     Constructor in C#:
    -one kind of special method of class
    -its means same name as class name
    -never return any value
    -are called auromatically when object of class is created
    -used to initialize private members within a class
    
    =>Default Constructor: Does not take any arguments assigns default values to data members.
    =>parameterless constructor: Arguments in constructor take care to pass the same number of arguments at the time of object creation.
      -when we have not written any constructor in class, compiler automatically creates a default constructor.
    =>Copy Constructor: want to create a new object from exist object, provide same set value to all members of a class ,object as an argument is passed.
    =>Static Constructor:static key word with constructor not take any arguments
      -Called only once ,initialize the static members which belongs to class
    =>Private Constructor: it is private and parameter-less 
      -when all members of a class are static 
      -never allowed to create objects.
     */
    class student
    {
       
        int rlno;
        string name;

        public student()
        {
            Console.WriteLine("Enter the roll no. :");
            rlno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name: ");
            name=Convert.ToString(Console.ReadLine());
        }
        
        public void showData()
        {
            Console.WriteLine("Roll No: " + rlno);
            Console.WriteLine("Name: " + name);
        }
    }
    internal class Constructor
    {
        public static void Main()
        {
            student s1 = new student();
            s1.showData();
            student s2 = new student();
            s2.showData();
        }
        
    }
}
