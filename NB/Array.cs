using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB
{
    internal class Array
    {
        internal static void Sort(int[] a)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            //int[] arr =new int[5]; 
            int[] arr = {1,2,3,4,5};
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine("---------------");

            int[] arr1 = new int[5];
            int m=arr1.Length;
            for (int i = 0; i < m; i++)
            {
                arr1[i]=Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ");
            foreach (int j in arr1)
            {
                Console.WriteLine(j);
            }
        }
    }
}
