using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array9                      //find minimum chararacter from array
    {
        public static char FindMin(char[] ch)
        {
            char min = ch[0];
            for (int i = 0; i <= ch.Length-1; i++)
            {
                if (min > ch[i])
                {
                    min = ch[i];
                }
            }
            return min;
        }
        static void Main(String[] args)
        {
            char[] ch = { 'a', 'E', 'i', 'O', 'A', 'B' };
            for(int i = 0; i <= ch.Length-1; i++)
            {
                Console.WriteLine(ch[i]);
            }
            char p = Array9.FindMin(ch);
            Console.WriteLine("Min Character:" + p);
        }
    }
}
