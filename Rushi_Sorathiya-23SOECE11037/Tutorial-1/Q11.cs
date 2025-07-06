using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q11
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Gender (M/F) ? ");
            string gender= Console.ReadLine().ToUpper();
            if (gender == "M")
            {
                Console.WriteLine("Mr." + name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Ms." + name);
            }
            else
            {
                Console.WriteLine("Answer only 'M' or 'F'. ");
            }
        }
    }
}
