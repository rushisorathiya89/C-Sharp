using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB
{
    internal class MaxEle
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

            //Console.WriteLine("Print the Array");
            //foreach (int k in arr1)
            //{
            //    Console.WriteLine(k);
            //}

           
            int j = 0;
            while (j < m) {
                for (int n = j+1; n < m; n++)
                {
                    if (arr1[j] > arr1[n])
                    {
                        int temp = arr1[j];
                        arr1[j]= arr1[n];
                        arr1[n]= temp;
                    }
                }
                j++; 
            }
            Console.WriteLine("the maximum " + arr1[m-1]);

        }
    }
}
