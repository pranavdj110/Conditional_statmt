using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week3_exam_6August
{
    class Pattern1
    {
        static void Main(String[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");

                }
                for(int p = 1; p <= i; p++)
                {
                    Console.Write(p);
                }
                
                for (int s =1 ; s+1<= i; s++)
                {
                    Console.Write(i+s);
                }
                Console.WriteLine();
            }
        }
    }
}
