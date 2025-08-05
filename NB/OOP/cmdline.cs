using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    internal class cmdline
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Command line arguments");
            Console.WriteLine("First arg " + args[0]);
            Console.WriteLine("second arg " + args[1]);
        }
    }
}
