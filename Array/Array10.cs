using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array10                //Replace 0 with 1
    {
        static void Main(String[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0 };
            Console.WriteLine("Array before:");
            Console.WriteLine(String.Join(" ", arr));
             for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine("Array After:");
            Console.WriteLine(String.Join(" ", arr));
            
        }
    }
}
