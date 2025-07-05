using System;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    class Q4 {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            int x;
            x = Convert.ToInt32(str);
            if (x % 2 == 0) {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.Read();
        }
    }
}



