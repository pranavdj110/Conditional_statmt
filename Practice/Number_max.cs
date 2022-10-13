using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Practice
{
    class Number_max
    {
        static void Main(String[] args)
        {
            int num = 232;
            //int min = num;
            int sum = 0;
            int mul = 1;
            //int count = 0;
            //int num1 = num;
            /* while (num1 > 0)
             {
                 int r = num1 % 10;
                 count++;
                 num1 = num1 / 10;
             }*/
            while (num > 0)
            {
                int m = num % 10;

                sum = sum * 10 + m;
                num = num / 10;
                
            }
            Console.WriteLine(sum);
        }
    }
}
