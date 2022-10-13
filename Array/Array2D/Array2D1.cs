using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array.Array2D
{
    class Array2D1                   //Addition of two array
    {
        static void Main(String[] args)
        {
            int[,] arr = { { 5,6},
                           {1,2 }
                         };
            int[,] arr1 = { { 1,3},
                           {4,9 }
                         };
            Console.WriteLine("First Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + arr1[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
