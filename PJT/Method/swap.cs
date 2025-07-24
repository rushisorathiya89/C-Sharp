using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Method
{
    internal class swap
    {
        static void swapnum(ref int i,ref int j)//i and j is reference variables 
        {
            //int temp;
            //temp = i;
            //i = j;
            //j=temp;

            i = i + j;//i=30
            j = i - j;//j=10
            i = i - j;//i=20
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before swapping {a} and {b}");
            swapnum(ref a,ref b );//passing the args by reference
            Console.WriteLine($"After swapping {a} and {b}");
        }
    }
}
