using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.Pettern
{
 /*

 * * * * * * * * *
  * * * * * * *
    * * * * *
      * * *
        *
        
     */
    internal class P9
    {
        static void Main(String[] args)
        {
            int n = 5;
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("  ");
                }
                
                for(int k=0; k< 2*n - ( (2*i) + 1 ); k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
