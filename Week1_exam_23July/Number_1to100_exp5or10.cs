using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_23July
{
    class Number_1to100_exp5or10
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5!=0&&i%10!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
