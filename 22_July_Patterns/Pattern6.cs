using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._22_July_Patterns
{
    class Pattern6
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    
                    if (i % 2 != 0)
                    {

                        Console.Write(j);

                    }
                    else
                    {
                       char ch = 'A';
                        

                        Console.Write(ch);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
