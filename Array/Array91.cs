using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array91                            //Merge two array avoid duplication
    {
        static void Main(String[] args)
        {
            int[] arr1 = { 2, 5, 6, 8, 4 };
            int[] arr2 = { 3, 9, 1, 8, 4 };
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
            //  Console.WriteLine(arr1.Length);
            //  Console.WriteLine(arr2.Length);
            int length = arr1.Length + arr2.Length;
           // Console.WriteLine(length);
            int[] arr3 = new int[length];
            for(int i = 0; i <= length/2 - 1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = length / 2; i <= length - 1; i++) 
            { 

                if (arr2[i - 5] != arr1[0] && arr2[i - 5] != arr1[1] && arr2[i - 5] != arr1[2] && arr2[i - 5] != arr1[3] && arr2[i - 5] != arr1[4])
                {
                    arr3[i] = arr2[i - 5];
                }
            }
            Console.WriteLine(string.Join(" ", arr3));
        }
    }
}
