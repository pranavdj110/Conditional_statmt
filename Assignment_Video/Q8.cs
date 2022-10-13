using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q8
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter a Number:");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even number.");
            }
            else
            {
                Console.WriteLine("Odd number.");
            }
        } 
    }
}
