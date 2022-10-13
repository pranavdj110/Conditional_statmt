using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._07_SEPT_2022
{
    class Q1
    {
        static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            int count = arr.Length + 1;
            int sum = count * (count + 1) / 2;
            int sum1 = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum1 = sum1 + arr[i];
            }

            int m_number = sum - sum1;
            Console.WriteLine("Missing number is:" + m_number);


           
        }
    }
}
