using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of terms:");
            int term = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number : ");
            int n = Convert.ToInt32(Console.ReadLine()); ;
            int sum = 0;
            int temp = n;
            for (int i = 0; i < term; i++)
            {

                if (i == term - 1)
                {
                    Console.Write(temp);
                }
                else
                {
                    Console.Write(temp + " + ");
                }

                sum += temp;
                temp = n + (temp * 10);
               
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the series is: " + sum);
        }
    }
}
