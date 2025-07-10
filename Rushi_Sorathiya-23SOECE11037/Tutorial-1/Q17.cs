using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q17
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                for (int j = 1; j <= i; j++) { 
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
