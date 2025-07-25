using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the Element: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            Console.WriteLine("Array elements in ascending order : ");
            //for(int i=0;i<arr.Length-1; i++)
            //{
            //    for(int j=i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
