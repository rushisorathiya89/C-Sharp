using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n%2 == 0)
            {
                Console.WriteLine(n + " is Even.");
            }
            else
            {
                Console.WriteLine(n + " is Odd.");
            }
        }
    }
}
