using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Q06          //separate zeros
    {
        static void Main(String[] args)
        {
            int[] arr = { 5, 0, 2, 0, 6, 0 };
            Console.WriteLine(string.Join(" ", arr));
            int p = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[p] = arr[i];
                    p++;
                }
            }
            while(p<arr.Length)                         //p=3  length=6   3-6 
            {
                arr[p] = 0;
                p++;
            }
            Console.WriteLine(string.Join(" ", arr));
            
        }
    }
}
