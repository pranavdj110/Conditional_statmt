using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Q9                    //predict the output
    {
        public static void Main(String[] args)
        {
            int[] var = new int[10];
            for(int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] + " ");     //0,2,4,6,8
                i++;
            }
        }
    }
}
