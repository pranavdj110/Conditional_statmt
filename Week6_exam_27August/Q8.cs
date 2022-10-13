using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week6_exam_27August
{
    class Q8
    {
        static void Main(String[] args)
        {
            string[] str1 = { "winter", "fall", "summer", "spring" };
            string str2 = "";
            int j = 0;
            for(int i = 0; i < str1.Length; i++)
            {
                string s = str1[i];
                char ch = s[i];
                str2 = str2 + ch;
                
            }
            Console.WriteLine(str2);
            
        }
    }
}
