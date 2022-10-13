using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._24_Aug_2022
{
    class Program2       //if vowel then inrement by 1 character
    {
        static void Main(String[] args)
        {
            string str = "pranav";
            string str1 = " ";
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]=='a'|| str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    str1 =str1+ (char)(str[i]+1);
                }
                else
                {
                    str1 = str1 + str[i];
                }
            }
            Console.WriteLine(str1);
        }
    }
}
