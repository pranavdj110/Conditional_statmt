using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._03_Aug_2022
{
    class Program4
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter number:");
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    int num1 = num;
                    int sum = 0;
                    int temp;
                    int r;
                    int total;

                    while (num > 0)
                    {
                        r = num % 10;
                        sum = (sum * 10) + r;

                        num = num / 10;
                    }

                    if (num1 == sum)
                    {
                        Console.WriteLine("Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("not Palindrome");
                    }
                }
                else
                {
                    Console.WriteLine("Stop");
                    break;
                }
            }
        }
    }
}
