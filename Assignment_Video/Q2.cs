using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q2
    {
        static void main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if(num%5==0 && num%11==0)
            {
                Console.WriteLine("Number is divisible by 5 and 11.");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 and 11.");
            }
        }
    }
}
