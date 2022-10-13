using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array.Array2D.Patterns
{
    class Pattern1        //N Pattern
    {
        static void Main(String[] args)
        {
            int[,] arr = new int[5, 5];
            for(int i = 0; i < arr.GetLength(0); i++)
            {                                                         //Input
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Enter element:");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }

            }
            for (int i = 0; i < arr.GetLength(0); i++)             //Display Input
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("N Pattern:");                    //Display N
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   if(j==0||j==arr.GetUpperBound(1)|| i == j)           
                    {
                        Console.Write(arr[i, j]);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
