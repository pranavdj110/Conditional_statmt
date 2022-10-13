using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt
{
    /*class Program1
    {
        static void Main(String[] args)
        {
            int[] arr = {1, 4, 3, 5, 6,5,4,8,6};
            //4,9,13
            for(int i = 1; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(arr[i] + arr[i - 1]);
                }
            }
        }
       
    }*/


    class SortString
    {
        static void Main(String[] args)
        {
            string temp = "";
            string[] str = { "om", "avinash", "rohit", "virat" };
            for (int i = 0; i < str.Length-1; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if ((str[j].CompareTo(str[i])) == -1)
                    {
                        temp = str[j];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                    
                }

            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}



