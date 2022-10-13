using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_23July
{
    class Odd_square_even_num
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);

                }
                else
                {
                    Console.WriteLine(i * i);
                }
            }
        }
    }
}
