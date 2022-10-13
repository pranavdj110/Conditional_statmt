using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week6_exam_27August
{
    class Q1
    {
        static string Revrse(string str)
        {
            string str1 = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }
            return str1;
        }
        static void Main(String[] args)
        {
            string str1 = "abccbalkm";
            string[] str2=new string[3];
            int p = 0;
           
           for(int i = 0; i < str1.Length-2; i++)
            {
                for (int j = i + 1; j < str1.Length-i; j++)
                {
                    string str3 = str1.Substring(i, j);
                    string str4 = Q1.Revrse(str3);
                    bool b = str3 == str4;
                    if (b == true)
                    {
                        str2[p] = str3;
                        Console.WriteLine(str3);
                        p++;
                    }
                }

                 
            }

            Console.WriteLine(string.Join(" ", str2));
            int max = str2[0].Length;
            for (int i = 0; i < str2.Length - 1; i++)
            {
                for (int j = i + 1; j < str2.Length; j++)
                {
                    if (str2[i].Length < str2[j].Length)
                    {
                        string temp = str2[i];
                        str2[i] = str2[j];
                        str2[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", str2));
            Console.WriteLine(str2[0]);
         }
    }
}
