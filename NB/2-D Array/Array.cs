using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB._2_D_Array
{
    internal class Array
    {
        static void Main(String[] args)
        {
            //int[,] ary = new int[2, 2];
            //ary[0, 0] = 1;
            //ary[0, 1] = 2;
            //ary[1, 0]= 3;
            //ary[0, 1]= 4;
            //Console.WriteLine("first ele:" + ary[0,0]);

            //2x3 array
            //int[,] ary1 = { { 1, 2,3 }, { 3, 4,6 } };
            //Console.WriteLine(ary1[1,2]);

            int[,] ary1 = new int[3, 3];
            Console.WriteLine("Enter element of 3x3 array: ");
            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0;  j < ary1.GetLength(0);  j++)
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
        }
    }
}
