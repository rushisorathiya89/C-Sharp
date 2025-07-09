using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q14
    {
        static void Main(string[] strings)
        {
            string[] arr = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string n = "98732";
            foreach (var i in n) 
            {
                int digit = i - '0'; 
                Console.Write(arr[digit] + " ");
            }
        }
    }
}
