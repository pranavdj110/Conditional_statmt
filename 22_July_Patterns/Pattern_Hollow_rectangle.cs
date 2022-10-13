using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._22_July_Patterns
{
    class Pattern_Hollow_rectangle
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if(j%5==0 || j==1||i==1||i==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
