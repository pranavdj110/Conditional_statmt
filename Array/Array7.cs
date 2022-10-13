using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array7                               //Min number from array.
    {
        
            public static int MinInt(int[] arr)
            {

                int min = arr[0];
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                }
                return min;
            }
            static void Main(String[] args)
            {
                int[] arr = { 8, 10, 9, 6, 8, 4 };
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                int min1 = Array7.MinInt(arr);
                Console.WriteLine("Min number is:" + min1);

            }
        }
    
}
