using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2._1
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            args = new string[] { "A", "B", "C", "D" };
            Console.WriteLine("Hello, World!");
            Console.WriteLine("You entered the following {0} command line arguments:",
               args.Length);

            Console.WriteLine(args[0]);              // ← Missing statement-2
            Console.WriteLine(args[1]);              // ← Missing statement-2
            Console.WriteLine(args[2]);              // ← Missing statement-2
            Console.WriteLine(args[3]);              // ← Missing statement-2


            // Missing statement-1 to 4:
            //for (int i = 0; i < args.Length; i++)        // ← Missing statement-1
            //{
            //    Console.WriteLine(args[i]);              // ← Missing statement-2
            //}                                           // ← Missing statement-3
            //Console.ReadLine();                         // ← Missing statement-4
        }
    }
}
