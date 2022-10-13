using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._03_Aug_2022
{
    class Program1
    {
        static void Main(String[] args)
        {
            int num;
            bool isPrime = true;
            Console.WriteLine("Enter number:");
            num = int.Parse(Console.ReadLine());

            
            while(num>=0)
            {
                for (int i = 2; i <= num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine("Enter number:");
                    num = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine("Stop");
        }
    }
}
