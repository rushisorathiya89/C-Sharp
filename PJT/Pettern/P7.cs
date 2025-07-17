using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Pettern
{
    internal class P7
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if ((i+j) % 2 == 0)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
