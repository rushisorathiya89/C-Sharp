using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2
{
    internal class Q7
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter the element :");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] even = new int[5];
            int[] odd = new int[5];
            for (int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even[i] = numbers[i];
                }
                else
                {
                    odd[i] = numbers[i];
                }
            }
            Console.WriteLine("Even numbers are:");
            for (int i = 0; i < even.Length; i++)
            {
                if (even[i] != 0)
                {
                    Console.Write(even[i] + " ");
                }
            }
            Console.WriteLine("\nOdd numbers are: ");
            for (int i = 0; i < odd.Length; i++)
            {
                if (odd[i] != 0)
                {
                    Console.Write(odd[i] + " ");
                }
            }
        }
    }
}
