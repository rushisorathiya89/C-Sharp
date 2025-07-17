using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Pettern
{
    internal class P6
    {
        static void Main(string[] args)
        {
            int n = 5;
            //int count = 1;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1 && i>0)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.Write(n+ " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
