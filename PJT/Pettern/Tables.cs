using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Pettern
{
    internal class Tables
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1;  j <=10 ; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i*j);
                  
                }
                Console.WriteLine();
            }
        }
    }
}
