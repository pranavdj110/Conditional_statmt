using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week7_exam
{
    class Q2
    {
        static void Main(String[] args)
        {
            int[] arr = { 2, 4,3, 5, 6, 2, 4, 7, 8, 9 };
            int sum = 7;

            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine("{" + arr[i] + "," + arr[j] + "}");
                    }
                }
            }
        }
    }
}
