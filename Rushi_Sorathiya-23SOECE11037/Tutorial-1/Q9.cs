using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_1
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            string str = "JoHn F kEnNedy";
            string ans = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    ans += char.ToLower(str[i]);
                }
                else
                {
                    ans += char.ToUpper(str[i]);
                }
            }
            Console.WriteLine(ans);
        }
    }
}
