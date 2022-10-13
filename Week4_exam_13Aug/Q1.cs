using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug 
{
    class Q1                //Program to count even and odd elements from an array.
    {
        static void Main(String[] args)
        {
            int count_even = 0;
            int count_odd = 0;
            int[] arr = { 2, 6, 8, 9, 13, 20 };
            Console.WriteLine(string.Join(" ", arr));
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count_even++;
                }
                else
                {
                    count_odd++;
                }
            }
            Console.WriteLine("Number of Even elements:" + count_even);
            Console.WriteLine("Number of Odd elements:" + count_odd);

        }
    }
}
