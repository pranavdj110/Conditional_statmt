using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._24_Aug_2022
{
    class Program3   //encryption increment each character by 2
    {
        static void Main(String[] args)
        {
            string str = "pranav";
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str1 + (char)((int)str[i] + 2);
            }
            Console.WriteLine(str1);
        }
    }
}
