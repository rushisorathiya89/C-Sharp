using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037.Tutorial_2._1
{
    internal class Q10
    {
        public static int matSearch(int[,] mat, int N, int M, int X)
        {
            for (int i = 0; i < N; i++)
            {
                int left = 0, right = M - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (mat[i, mid] == X)
                        return 1; 
                    else if (mat[i, mid] < X)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[,] mat = {
            {3, 30, 38},
            {44, 52, 54},
            {57, 60, 69}
        };

            int N = 3, M = 3, X = 52;

            int result = matSearch(mat, N, M, X);
            Console.WriteLine(result);  
        }
    }
}
