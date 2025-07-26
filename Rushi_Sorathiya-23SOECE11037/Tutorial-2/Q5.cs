using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter the element :");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool[] ans= new bool[numbers.Length];
            for (int i = 0;i < numbers.Length; i++)
            {
                if (ans[i])
                {
                    continue;
                }


            }
        }
    }
}
