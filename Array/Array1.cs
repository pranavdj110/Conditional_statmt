using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array1           //reverse char array
    {
        static void Main(String[] args)
        {
            char[] ch = { 'a', 'b', 'c', 'd' };
            for(int j = 0; j <= ch.Length-1; j++)
            {
                Console.WriteLine(ch[j]);
            }
            for(int i = ch.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ch[i]);
            }
        }
    }
}
