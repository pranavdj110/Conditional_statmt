using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._21_July_doWhile
{
    class Skip3_1to30
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=30;i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
