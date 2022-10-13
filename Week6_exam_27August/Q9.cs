using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week6_exam_27August
{
    class Q9
    {
        static void Main(String[] args)
        {
            string str1 = "thin sticks";
            string str2 = "thick bricks";
            string str3 = "";

            foreach(char ch in str1)
            {
                if (str2.Contains(ch))
                {
                    if(!str3.Contains(ch) && ch!=' ')
                    str3 = str3 + ch;
                }
            }
            Console.WriteLine(str3);
            char[] arr = new char[str3.Length];
            for(int i = 0; i < str3.Length; i++)
            {
                arr[i] = str3[i];
            }
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        char temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
