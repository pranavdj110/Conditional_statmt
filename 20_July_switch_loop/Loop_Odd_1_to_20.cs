using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._20_July_switch_loop
{
    class Loop_Odd_1_to_20
    {
        static void Main(String[] args)
        {
           for(int i = 1;i<= 20;i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
