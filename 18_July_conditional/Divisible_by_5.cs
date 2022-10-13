using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt
{
    class Divisible_by_5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());
            if(num%5==0)
            {
                Console.WriteLine("The Number is divisible by 5");
            }
            else
            {
                Console.WriteLine("The Number is not divisible by 5");
            }
        }
    }
}
