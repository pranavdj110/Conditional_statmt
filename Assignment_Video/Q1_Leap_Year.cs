using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q1_Leap_Year
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Year:");
            int num = int.Parse(Console.ReadLine());
            if (num%400==0)
            {
                // if (num / 100) ;
                Console.WriteLine("Leap year");

            }
            else if(num%100==0)
            {
                Console.WriteLine(" not a Leap year");
            }
            else if(num%4==0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("not a Leap year");
            }
        }
    }
}
