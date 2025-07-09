using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int input =Convert.ToInt32(Console.ReadLine());

            string str= input.ToString();
            int originalNumber = input;
            int sum = 0;
            foreach (var i in str)
            {
                int digit = i - '0';
                sum += (int)Math.Pow(digit,3);
            }
            if (sum == originalNumber)
            {
                Console.WriteLine(originalNumber + " is the Armstrong Number.");
            }
            else
            {
                Console.WriteLine(originalNumber +  "is not Armstrong Number.");
            }
        }
    }
}
