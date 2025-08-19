using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2._1
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            double d = 10.5;
            float f = 5.7f;
            char c = 'X';
            string s = "Hello";
            bool flag = true;

            Console.WriteLine("\n=== Arithmetic Operators ===");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"A / B = {(double)A / B}");
            Console.WriteLine($"A % B = {A % B}");

            Console.WriteLine("\n=== Relational Operators ===");
            Console.WriteLine($"A > B : {A > B}");
            Console.WriteLine($"A < B : {A < B}");
            Console.WriteLine($"A >= B : {A >= B}");
            Console.WriteLine($"A <= B : {A <= B}");
            Console.WriteLine($"A == B : {A == B}");
            Console.WriteLine($"A != B : {A != B}");

            Console.WriteLine("\n=== Logical Operators ===");
            Console.WriteLine($"(A > 5 && B > 5) : {A > 5 && B > 5}");
            Console.WriteLine($"(A > 5 || B > 5) : {A > 5 || B > 5}");
            Console.WriteLine($"!(A > B) : {!(A > B)}");

            Console.WriteLine("\n=== Bitwise Operators ===");
            Console.WriteLine($"A & B = {A & B}");
            Console.WriteLine($"A | B = {A | B}");
            Console.WriteLine($"A ^ B = {A ^ B}");
            Console.WriteLine($"A << 1 = {A << 1}");
            Console.WriteLine($"B >> 1 = {B >> 1}");

            Console.WriteLine("\n=== Assignment Operators ===");
            int x = A;
            Console.WriteLine($"x = {x}");
            x += B; Console.WriteLine($"x += B : {x}");
            x -= B; Console.WriteLine($"x -= B : {x}");
            x *= B; Console.WriteLine($"x *= B : {x}");
            x /= B; Console.WriteLine($"x /= B : {x}");

            Console.WriteLine("\n=== Different Data Types ===");
            Console.WriteLine($"Double: {d}");
            Console.WriteLine($"Float: {f}");
            Console.WriteLine($"Char: {c}");
            Console.WriteLine($"String: {s}");
            Console.WriteLine($"Boolean: {flag}");
        }
    }
}
