using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Practice
{
    class Subarey
    {
        static void Main(String[] args)
        {
            int[] arr = { 1, 0, 0, 1, 1, 0, 0, 1, 1 };
            /*int max = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int one = 0;
                int zero = 0;
                for(int j = i; j < arr.Length; j++)
                {
                    if(arr[j]==1)
                    {
                        one++;
                    }
                    else
                    {
                        zero++;
                    }
                    if (one == zero)
                    {
                        if(max<j-i+1)
                        max = j - i + 1;
                    }
                }
            }
            Console.WriteLine(max);*/
            /*int max = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int one = 0;
                int zero = 0;
                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 1)
                    {
                        one++;
                    }
                    else
                    {
                        zero++;
                    }
                    if (one == zero)
                    {
                        if(max<j-i+1)
                        max = j - i + 1;
                    }
                }
            }
            Console.WriteLine(max);*/
            string s1 = "arm";string s2 = "ramm";bool flag = true;
            foreach(char ch in s1)
            {
                int count1 = 0; int count2 = 0;
                foreach(char a1 in s1)
                {
                    if (ch == a1)
                    {
                        count1++;
                    }
                }
                foreach(char a2 in s2)
                {
                    if (ch == a2)
                    {
                        count2++;
                    }
                }
                if (count1 != count2)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not Anagram");
            }
        }
    }
}
