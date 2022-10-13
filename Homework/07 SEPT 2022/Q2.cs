using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._07_SEPT_2022
{
    class Q2      //series 0,3,8,15,24...........(squae-1)
    {
        static void Main(String[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i * i - 1 +",");
            }
        }
    }
}
