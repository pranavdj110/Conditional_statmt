using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._22_July_Patterns
{
    class Pattern2
    {
        static void Main(String[] args)
        {
            for(char i='D';i>='A';i--)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
