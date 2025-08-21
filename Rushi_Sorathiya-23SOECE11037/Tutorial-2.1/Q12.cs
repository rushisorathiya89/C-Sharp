using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2._1
{
    internal class Q12
    {
        static void Main(String[] args)
        {
            Console.Write("Enter number of elements in array: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            Console.WriteLine("Enter elements of array:");
            for (int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            int X = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < N; i++)
            {
                if (arr[i] == X)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("1"); 
            else
                Console.WriteLine("0");
        }
    }
}
