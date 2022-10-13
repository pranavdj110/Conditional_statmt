using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q3_max_three
    {
        static void main(String[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine(num1 + "is the greatest among three.");
                }
                else
                {
                    Console.WriteLine(num3 + "is the greatest among three.");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + "is the greatest among three.");
                }
                else
                {
                    Console.WriteLine(num3 + "is the greatest among three.");
                }
            }
        }
    }
}
