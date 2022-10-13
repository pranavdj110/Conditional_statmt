using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week6_exam_27August
{
    class Q4
    {
        static void Main(String[] args)
        {
            string str1 = "india is my country";
            Console.WriteLine("original:" + str1);
            string str2 = "";


            for (int i = str1.Length-1; i >= 0; i--)
            {
                if(str1[i]!=' ')
                str2 = str2 + str1[i];
            }
           // Console.WriteLine(str2);
           
            
            string str3 = "";
            int j = 0;
            for(int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != ' ') 
                { 
                    str3 = str3 + str2[j];
                    j++;
                }
                else
                {
                    str3 = str3 + ' ';
                }
            }

            Console.WriteLine("Result:"+str3);

            
        }
    }
}
