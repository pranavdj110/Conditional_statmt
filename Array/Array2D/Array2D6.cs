using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array.Array2D
{
    class Array2D6               //Sparse matrix:number of zeros are greater than non-zeros
    {
        static void Main(String[] args)
        {
            int[,] arr = new int[5, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
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

            int count = 0;
            int count1 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)             
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        count++;
                    }
                    else
                    {
                        count1++;
                    }
                }
               
            }
            Console.WriteLine("Zeros:" + count);
            Console.WriteLine("non Zeros:" + count1);
            if (count > count1)
            {
                Console.WriteLine("Sparse Matrix");
            }
            else
            {
                Console.WriteLine("not Sparse Matrix");

            }

        }
    }
}
