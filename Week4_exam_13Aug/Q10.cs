using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Q10           //Program to find perfect square from array.
    {
        static void Main(String[] args)
        {
            int[] arr = { 5, 4, 8, 9, 12, 16,225,321 };
            Console.WriteLine(String.Join(" ", arr));

            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = arr[j] / 2; i >= 1; i--)
                {
                    if (i * i == arr[j])
                    {
                        Console.WriteLine(arr[j]);
                    }

                }
            }
        }
    }
}
