using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework
{
    class Program01
    {
        static void Main(String[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            while (num!= 0)
            {
                if (num < 0)
                {

                    sum = sum + num;
                    Console.WriteLine("Enter number:");
                    num = int.Parse(Console.ReadLine());
                }
                else if (num > 0)
                {
                    Console.WriteLine(num);
                    Console.WriteLine("Enter number:");
                    num = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Sum of negative numbers is:"+sum);
        }
    }
}
