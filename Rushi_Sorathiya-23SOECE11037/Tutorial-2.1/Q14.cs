using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2._1
{
    internal class Q14
    {
        static void Main(String[] args)
        {
            Console.Write("Input the marks obtained in Maths: ");
            int math = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics: ");
            int phy = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chem = int.Parse(Console.ReadLine());

            int total = math + phy + chem;
            int totalMathPhy = math + phy;

            if (math >= 65 && phy >= 55 && chem >= 50 &&
               (total >= 180 || totalMathPhy >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
