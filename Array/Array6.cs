using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array6        //Max number from array.
    {
        public static int MaxInt(int[] arr)
        {
            
            int max = arr[0];
            for(int i = 0; i <= arr.Length-1; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static void Main(String[] args)
        {
            int[] arr = { 8, 10, 9, 6, 8, 4 };
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int max1= Array6.MaxInt(arr);
            Console.WriteLine("Max number is:" + max1);

        }
    }
}
