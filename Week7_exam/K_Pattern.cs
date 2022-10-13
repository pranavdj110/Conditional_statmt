using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week7_exam
{
    class K_Pattern
    {
        static void  Main(String[] args)
        {
            for(int i = 9; i >=1; i--)
            {

                if (i >= 5)
                {
                    char ch = 'A';
                    for (int j = 1; j <= i - 4; j++)
                    {
                        if (i % 2 != 0)
                            Console.Write(j);
                        else
                        {
                            Console.Write(ch);
                            ch++;
                        }


                    }
                    Console.WriteLine();
                }
                else
                {
                    char ch = 'A';
                    int n = 1;
                    for(int j = 6; j> i; j--)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(n);
                            n++;
                        }
                            
                        else
                        {
                            Console.Write(ch);
                            ch++;
                        }


                    }
                    Console.WriteLine();

                }
               
                
            }
        }
    }
}
