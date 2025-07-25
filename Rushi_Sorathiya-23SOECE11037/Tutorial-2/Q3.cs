using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in reverse order:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine($"Element [{i}]: {arr[i]}");
            }
        }
    }
}
