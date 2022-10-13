using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week6_exam_27August
{
    class Q7
    {
        static void Main(String[] args)
        {
            String str1 = "i love uk country";
            string[] arr = str1.Split(" ");
            Console.WriteLine(string.Join(" ", arr));
           // Console.WriteLine(arr[2]);

            for(int i = 0; i < arr.Length-1; i++)
            {
               for (int j = i+1;j < arr.Length; j++)
                {
                    if (arr[i].Length > arr[j].Length)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
