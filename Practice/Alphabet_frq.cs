using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Practice
{
    class Alphabet_frq
    {
        static void Main(String[] args)
        {
            string s = "thinkquoitent";
            string s1 = "";
            int count = 0;
            int count_max = 0;
            char count_max_char = ' ';
            for(int i = 0; i < s.Length; i++)
            {
                if (!s1.Contains(s[i]))
                {
                    s1 = s1 + s[i];
                }
            }


            for(int i = 0; i < s1.Length; i++)
            {
                for(int j = 0; j < s1.Length; j++)
                {
                    if (s1[i] == s[j])
                    {
                        count++;
                        if (count > count_max)
                        {
                            count_max = count;
                            count_max_char = s1[i];
                        }
                    }
                }
            }
            Console.WriteLine(count_max_char);
        }
    }
}
