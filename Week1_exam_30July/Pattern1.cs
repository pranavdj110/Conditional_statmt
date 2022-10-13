using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_30July
{
    class Pattern1
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write(i - j);
                }
                Console.WriteLine();
            }
        }
    }
}
