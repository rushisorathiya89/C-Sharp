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
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        ans[j] = true;
                        count++;
                    }
                }
                Console.WriteLine("Frequency of {0} is {1} ", numbers[i], count);
            }
        }
    }
}
