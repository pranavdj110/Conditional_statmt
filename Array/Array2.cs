using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array2        //Sum of array elements
    {
        static void Main(String[] args)
        {
            int sum = 0;
            int[] arr = { 3, 5, 6, 7 };
            for(int j=0;j<= arr.Length - 1; j++)
            {
                Console.WriteLine(arr[j]);
            }
            for(int i = 0; i <= arr.Length - 1; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of array element is:" + sum);
        }
    }
}
