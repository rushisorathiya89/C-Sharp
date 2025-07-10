using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Pettern
{
    internal class IncrementOp
    {
        static void Main(string[] args)
        {
            int a = 5;
            //int b = 5; 0 
            int res = a++;
            Console.WriteLine(res);
        }
    }
}
