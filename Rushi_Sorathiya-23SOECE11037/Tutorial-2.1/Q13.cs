using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2._1
{
    internal class Q13
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the amount: ");
            int amount = int.Parse(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in notes)
            {
                int count = amount / note;
                if (count > 0)
                {
                    Console.WriteLine($"Notes of Rs.{note} = {count}");
                    amount = amount % note;
                }
                else
                {
                    Console.WriteLine($"Notes of Rs.{note} = 0");
                }
            }
        }
    }
}
