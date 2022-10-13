using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week5_exam_20August
{
    class Q7
    {
        static void Main(String[] args)
        {
            int[,] arr = { { 5,6,1},
                           {1,2,6 },
                           {9,6,0 }
                         };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }

                }
                Console.WriteLine("Row " + i + " max element:" + max);

            }

        }
    }
}
