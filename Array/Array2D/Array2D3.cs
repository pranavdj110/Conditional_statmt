using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array.Array2D
{
    class Array2D3                                      //Average of each row
    {
        static void Main(String[] args)
        {
            int[,] arr = { { 5,6,1},
                           {1,2,6 },
                           {9,6,0 }
                         };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                int count = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[i, j];
                    count++;
                }
                Console.Write("Row "+i+ " Average=" + sum/count);
                Console.WriteLine();
            }
        }
    }
}
