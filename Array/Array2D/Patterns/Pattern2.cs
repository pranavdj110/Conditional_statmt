using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array.Array2D.Patterns
{
    class Pattern2                    //Lower Triangle
    {
        static void Main(String[] args)
        {
            int[,] arr = new int[5, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Enter element:");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    //for (int j = 0; j <= i; j++)
                {
                    // Console.Write(arr[i,j]);
                    if (i >= j)
                    { 
                        Console.Write(arr[i, j]); 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
