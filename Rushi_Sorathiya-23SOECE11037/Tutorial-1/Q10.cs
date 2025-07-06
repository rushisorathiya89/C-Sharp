using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Mobile No. :");
            string mobileNo = Console.ReadLine();
            string newMobileNo = "";

            for (int i = 0; i < mobileNo.Length; i++)
            {
                if (i > 4)
                {
                    newMobileNo+="X";
                }
                else
                {
                    newMobileNo += mobileNo[i];
                }
            }
            Console.WriteLine("New Mobile No. : " + newMobileNo);
        }
    }
}
