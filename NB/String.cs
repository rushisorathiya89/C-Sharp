using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB
{
    internal class String
    {
        static void Main(string[] args)
        {
            string str1, str2, str3;
            Console.WriteLine("Enter the string 1: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the string 2: ");
            str2 = Console.ReadLine();
            Console.WriteLine("Enter the string 3: ");
            str3 = Console.ReadLine();

            int len = str1.Length;
            Console.WriteLine("Length is: " + len);
            str3=str3.ToLower();
            Console.WriteLine("string 3 to lower " + str3 );

            str2 = str2.ToUpper();
            Console.WriteLine("string 3 to Upper " + str2);

            str3 = str1 + " " + str3;
            Console.WriteLine("Combine string " + str3);
            //using concat
            str3 =string.Concat(str1, str2);
            Console.WriteLine("Combine string " + str3);

            //interpolationof string 
            int no = 100;
            str3 = $"muliplication of number is : {no * 10}";
            Console.WriteLine("String 3 is :" + str3);
        }
    }
}
