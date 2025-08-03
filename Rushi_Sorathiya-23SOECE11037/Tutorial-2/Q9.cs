using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter the element :");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the position to remove element: ");
            int pos=Convert.ToInt32(Console.ReadLine());
            pos = pos - 1;
            for (int i = pos;i < numbers.Length - 1;i++)
            {
                
                 numbers[i] = numbers[i+1];
                
            }

            Console.WriteLine("New Array");
            for(int i = 0; i< numbers.Length-1;i++)
            {
               
                 Console.Write(numbers[i] + " ");
                
            }
        }
    }
}
