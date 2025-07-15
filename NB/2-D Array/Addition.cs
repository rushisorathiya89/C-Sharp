using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB._2_D_Array
{
    internal class Addition
    {
        static void Main(String[] args)
        {

            int[,] ary1 = new int[2, 2];
            Console.WriteLine("Enter element of ary1 2x2 array: ");
            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(0); j++)
                {
                    ary1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(1); j++)
                {
                    Console.Write(ary1[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] ary2 = new int[2, 2];
            Console.WriteLine("Enter element of ary2 2x2 array: ");
            for (int i = 0; i < ary2.GetLength(0); i++)
            {
                for (int j = 0; j < ary2.GetLength(0); j++)
                {
                    ary2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(1); j++)
                {
                    Console.Write(ary1[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] sum = new int[2, 2];
            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(1); j++)
                {
                    sum[i, j] = ary1[i, j] + ary2[i, j];
                }
                Console.WriteLine();
            }

            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
