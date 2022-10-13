using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week6_exam_27August
{
    class Q6
    {
        static void Main(String[] args)
        {
            string str1 = "india is a great nation";
            string str2 = "in";

            string str3 = "";
            for(int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != 'i'&& str1[i] != 'n')
                {
                    str3 = str3 + str1[i];
                }
                
            }
            Console.WriteLine(str3);
        }
    }
}
