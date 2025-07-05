using System;
namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1 // Declare a namespace
{
    class Q5 //Define the class
    {
        static void Main(string[] args) //Main Method
        {
            int n, fact = 1; //Declare two integer variable
            Console.WriteLine("Enter Number : "); // Prompt the user to enter a number
            string str = Console.ReadLine(); //Read the user input as a string
            n = Convert.ToInt32(str); //converts the string input to an integer and store into n
            for (int i = 1; i <= n; i++) //Loop 1 to n
            {
                fact = fact * i; //multiply fact by i in each iteration
            }
            Console.WriteLine("Factorial : {0}", fact); //desplay the result
            Console.Read(); //pauses the output
        }
    }
}
