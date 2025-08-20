using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2._1
{
    internal class Q9
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Value of N : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int len = 2 * n + 2;
            int[] arr = new int[len];
            Console.WriteLine("Enter the Elements of Array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Elements which occur exactly once. : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
