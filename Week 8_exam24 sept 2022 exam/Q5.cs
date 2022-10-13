using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_8_exam24_sept_2022_exam
{
    class Q5
    {
        static void Main(string[] args)
        {
            int num = 345;
            int num1 = num;
            int count = 0;
            while (num1 > 0)
            {
                count++;
                num1 = num1 / 10;
            }
            //Console.WriteLine(count);
            int[] arr = new int[count];
            int i = 0;
            while (num > 0)
            {
                int t = num % 10;
                arr[i] = t;
                num = num / 10;
                i++;
            }


            int increasing = 0;
            int decreasing = 0;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] - arr[j + 1] > 0)
                {
                    increasing++;
                }
                else if(arr[j] - arr[j + 1] < 0)
                {
                    decreasing++;
                }
                
            }
           // Console.WriteLine(increasing);
            //Console.WriteLine(decreasing);
            
            if (count == increasing + 1)
            {
                Console.WriteLine("increasing");
            }
            else if (count == decreasing + 1)
            {
                Console.WriteLine("dencreasing");

            }
            else
            {
                Console.WriteLine("Bounce");
            }


        }
    }
}
