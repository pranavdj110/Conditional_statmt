using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._22_Aug_2022
{
    class Myclass        //reversing each word in a sentence 
    {
      public string Sreverse(string s)
        {
            string rev = "";
            for(int i = s.Length-1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            return rev;
        }
    }


    class Program3
    {
        static void Main(String[] args)
        {
            Myclass m = new Myclass();
            string str = "india is my country";
            string[] str1 = str.Split(' ');
            for(int i = 0; i < str1.Length; i++)
            {
                string j = m.Sreverse(str1[i]);
                Console.Write(j + " ");
            }
        }
    }
}
