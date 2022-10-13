using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._21_July_doWhile
{
    class Average_digit
    {
        static void Main(String[] args)
        {
            int num;
            int sum = 0;
            int count = 0;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            while(num>0)
            {
                int n = num % 10;
                sum = sum + n;
                num = num / 10;
                count++;
            }
            Console.WriteLine("Sum="+sum);
            Console.WriteLine("Number of Digits:"+count);
            Console.WriteLine("Average:"+sum/count);
        }
    }
}
