using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._22_July_Patterns
{
    class Pattern4_plus
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if (i==3||j%3==0)
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
