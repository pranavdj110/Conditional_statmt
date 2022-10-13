using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week5_exam_20August
{
    class Q2
    {
        static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(string.Join(" ", arr));
            int temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1]= temp;

            int temp1 = arr[1];
            arr[1] = arr[arr.Length - 2];
            arr[arr.Length - 2] = temp1;
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
