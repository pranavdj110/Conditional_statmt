using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._21_July_doWhile
{
    class NoDis_div_3and9
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=15;i++)
            {
                if(i%3==0 && i%9==0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
