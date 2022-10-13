using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week5_exam_20August
{
    class Q6
    {
        static void Main(String[] args)
        {
            int[,] arr = { { 1,2,3,4},
                           {5,6,7,8 }};


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int p = arr.GetLength(0) ;
            int[,] arrCopy = new int[2, 4];
            for (int i = 0; i < arrCopy.GetLength(0); i++)
            {
                for (int j = 0; j < arrCopy.GetLength(1); j++)
                {
                    arrCopy[i, j] = arr[i, p];
                    p--;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arrCopy.GetLength(0); i++)
            {
                for (int j = 0; j < arrCopy.GetLength(1); j++)
                {
                    Console.Write(arrCopy[i, j] + " ");
                }
                Console.WriteLine();
            }
        } 
    }
}
