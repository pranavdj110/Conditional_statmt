using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_30July
{
    class Pattern3
    {
        static void Main(String[]args)
        {
            int n = 0;
            for(int i = 0; i <=4; i++)
            {
                n = (n * 10 + 1)  ;
                Console.WriteLine(n*(i+1));
            }
        }
    }
}
