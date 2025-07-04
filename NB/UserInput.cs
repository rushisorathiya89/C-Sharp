using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            //String a = Console.ReadLine();
            //Console.WriteLine("Name :" + a);
            //Console.ReadLine();

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Console.WriteLine("\n");

            //int i1 = 10;
            //while (i1 >= 0)
            //{
            //    Console.WriteLine(i1);
            //    i1--;
            //}
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 )
                {
                    Console.WriteLine(i + " is Even");
                }
                
            }
        }
    }
}
