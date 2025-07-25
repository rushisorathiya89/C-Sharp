using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2
{
    internal class Q4
    {
       static void Main(string[] args)
       {
            int[] numbers =new int[5];
            Console.WriteLine("Enter the element :");
            for(int i=0; i<numbers.Length; i++) {
                numbers[i] =Convert.ToInt32(Console.ReadLine());
            }

            int[] numbers1=new int[numbers.Length];
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = numbers[i];
            }

            Console.WriteLine("Original Array :");
            foreach (int i in numbers)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine("\nCopied Array: ");
            foreach(int i in numbers1)
            {
                Console.Write(i + " ");
            }
       }
    }
}
