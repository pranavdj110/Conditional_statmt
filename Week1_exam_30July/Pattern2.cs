using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_30July
{
    class Pattern2
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int b=i;b<=4;b++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else 
                    {
                        Console.Write("1"); 
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
