using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Practice
{
    class Array_neg
    {
        static void Main(String[] args)
        {
            int[] arr = { -1, 3, -5, 7, -8, 9,-12 };
            int[] arr1 = new int[arr.Length];
            int start = 0;
            int last = arr.Length - 1;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr1[start] = arr[i];
                    start++;
                }
                else if (arr[i] < 0)
                {
                    arr1[last] = arr[i];
                    last--;
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
        }
    }
}
