﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2._1
{
    internal class Q8
    {
        public class NumberManipulator
        {
            public int getValues(out int x, out int y, out int z)

            {

                Console.WriteLine("Enter the first value: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second value: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second value: ");
                z = Convert.ToInt32(Console.ReadLine());
                int sum = x + y + z;

                return sum;

            }
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b, c, sum;
            sum = n.getValues(out a, out b, out c);
            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.WriteLine("After method call, value of c : {0}", c);
            Console.WriteLine("Sum : {0}", sum);
        }
    }
}
