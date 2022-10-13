using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_8_exam24_sept_2022_exam
{
    class Q6
    {
        static void Main(String[] args)
        {
            string str = "thinkquoitent is the best company to work for";
            for(int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine("The first non repeated character is: "+str[i]);
                    break;
                }
            }
        }
    }
}
