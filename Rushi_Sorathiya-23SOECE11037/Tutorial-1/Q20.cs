using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q20
    {
        static void Main(String[] args)
        {
            int n = 4;
            int i = 0;
            int count= 1;
            while (i <= n)
            {
                int space = n - i;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write(count + " ");
                    count++;
                }

                Console.WriteLine();
                i++;
            }
        }
    }
}
