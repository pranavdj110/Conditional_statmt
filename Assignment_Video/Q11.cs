using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Assignment_Video
{
    class Q11                     //Three digit number checking. if three digit display sum of first and third digit.
    {
        static void Main(String[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a Number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;

           while(num>0)
            {
                num = num / 10;
                count++;
            }
           if(count==3)
            {
                int d = num1 % 10;
                int d1 = num1 / 100;
                int sum = d + d1;
                Console.WriteLine("Sum of first and third digit=" + sum);
            }
            else
            {
                Console.WriteLine("Not a three Digit number.");
            }
        }
    }
}
