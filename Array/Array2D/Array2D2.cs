using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array.Array2D
{
    class Array2D2                        //Sum of column
    {
        static void Main(String[] args)
        {
            int[,] arr = { { 5,6},
                           {1,2 }
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
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[j, i];
                }
                Console.Write("Column Sum=" + sum);
                Console.WriteLine();
            }
        }
        
    }
}
