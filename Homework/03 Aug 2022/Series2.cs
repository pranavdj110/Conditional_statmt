using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._03_Aug_2022
{
    class Series2
    {
        static void Main(String[] args)
        {
            int n = 7;
            int p = 1;
            while (n > 0)
            {
                p = p * 2;
                int j = p + 1;


                Console.WriteLine(j);
                n--;
            }

        }
    }
}
