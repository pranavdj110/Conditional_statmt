using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array4        //Elements at even position
    {
        static void Main(String[] args)
        {
            int[] arr = { 3, 5, 6, 7,8,9 };
            for (int j = 0; j <= arr.Length - 1; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("Elements at Even Positions:");
            for (int j = 0; j <= arr.Length - 1; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(arr[j]);
                }

            }


        }
    }
}
