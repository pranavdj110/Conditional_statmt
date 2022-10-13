using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_23July
{
    class Factors
    {
        static void Main(String[]args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            for(int i=num;i>=1;i--)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
