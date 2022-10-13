using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array3      //Odd number count
    {
        static void Main(String[] args)
        {
            int count = 0;
            int[] arr = {10,19, 3, 5, 6, 7 };
            for (int j = 0; j <= arr.Length - 1; j++)
            {
                Console.WriteLine(arr[j]);
            }
            for (int j = 0; j <= arr.Length - 1; j++)
            {
                if (arr[j] % 2 != 0)
                {
                    count++;
                }
               
            }
            Console.WriteLine("Number of odd numbers:" + count);

        }
    }
}
