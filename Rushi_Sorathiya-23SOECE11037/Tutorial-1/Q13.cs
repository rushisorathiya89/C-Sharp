using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q13
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.Write(a + " " + b+ " ");
            for (int i = 2; i < 11; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }
        }
    }
}
