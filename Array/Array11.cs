using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array11          //If negative number then replace that negative number with the square of previous number.
    {
        static void Main(String[] args)
        {
            int[] arr = { 12,3,-19,29,5,-61,44,7,-9 };
            Console.WriteLine("Array before:");
            Console.WriteLine(String.Join(" ", arr));
            for(int i = 0; i <= arr.Length-1; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            Console.WriteLine("Array before:");
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
