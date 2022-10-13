using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_8_exam24_sept_2022_exam
{
    class Q2
    {
        static void Main(String[] args)
        {
            string str = "Nothing is as easy as it looks Nothing";
            string[] arr = str.Split(' ');
            /*for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }*/

            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = true;
                for(int k = i - 1; k >= 0; k--)
                {
                    if (arr[k] == arr[i])
                    {
                        flag = false;
                        break;
                    }
                }
                int count = 0;
                if (flag == true)
                {
                    //int count = 0;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + ":" + count);
                }
                
            }
        }
    }
}
