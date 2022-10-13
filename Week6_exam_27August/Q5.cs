using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week6_exam_27August
{
    class Myclass       
    {
        public string Sreverse(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            return rev;
        }
    }


    class Q5
    {
        static void Main(String[] args)
        {
            Myclass m = new Myclass();
            string str = "india is my country";
            string[] str1 = str.Split(' ');
            string j=" ";
            for (int i = 0; i < str1.Length; i++)
            {
                if (i != 0 && i != str1.Length - 1)
                {
                     j =j+ m.Sreverse(str1[i]);
                    j = j + ' ';

                }
                else
                {
                   j = j+str1[i];
                    if(i!=str1.Length)
                    j = j + ' ';
                }
                
            }
            Console.Write(j + " ");
        }
    }
}
