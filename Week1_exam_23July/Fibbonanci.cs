using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_23July
{
    class Fibbonanci
    {
        static void Main(String[] args)
        {
            int temp, num1, num2;
            num1 = 1;num2 = 1;
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            for (int i=1;i<=20;i++)
            {
                temp = num1 + num2;
                Console.WriteLine(temp);
                num1 = num2;
                num2 = temp;
            }
        }
    }
}
