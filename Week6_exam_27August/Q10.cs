using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week6_exam_27August
{
    class Q10
    {
        static void Main(String[] args)
        {
            bool flag = true;
            string str = "the sky is the limit";
            string str2 = "mit";
            foreach(char ch in str2)
            {
                if (!str.Contains(ch))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
