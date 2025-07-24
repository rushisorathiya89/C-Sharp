using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Method
{
    internal class Addition
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        /// cannot use non static members within static method 

        static int substarction(int x, int y)
        {
            return x - y;
        }

        static int multiplication(int x, int y)
        {
            return x * y;
        }

        static int Division(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            int a = 50;
            int b = 10;
            int sum;
            sum = Add(a, b);//addition
            int sub=substarction(a, b);
            int mul=multiplication(a, b);
            int div=Division(a, b);
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.WriteLine($"The Substraction of {a} and {b} is {sub}");
            Console.WriteLine($"The Multiplication of {a} and {b} is {mul}");
            Console.WriteLine($"The Division of {a} and {b} is {div}");
        }
        
    }
}
