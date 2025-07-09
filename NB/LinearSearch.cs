using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB
{
    internal class LinearSearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elemrnts:");
            int[] arr1 = new int[5];
            int m = arr1.Length;
            for (int i = 0; i < m; i++)
            {
                arr1[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Print the Array");
            foreach (int j in arr1)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("Enter the Search ele:");
            int s= Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 0; i < m; i++)
            {
                if (arr1[i] == s)
                {
                    flag = 1;
                    Console.WriteLine("Index of search element: "+ i);
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("\nElement not found in the array.");
            }


        }
    }
}
