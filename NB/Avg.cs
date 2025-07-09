using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB
{
    internal class Avg
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
            int sum = 0;
            for (int k = 0; k < m; k++)
            {
                sum += arr1[k];
            }
            Console.WriteLine("The sum is :" + sum);
            int avg=sum/arr1.Length;
            Console.WriteLine("The average is : " +avg);
        }
    }
}
