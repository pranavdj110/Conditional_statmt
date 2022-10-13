using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._20_July_switch_loop
{
    class Loop_Addition_1_to_10
    {
        static void Main(String[] args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum is" + sum);
        }
    }
}
