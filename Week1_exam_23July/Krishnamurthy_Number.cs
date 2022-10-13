using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_23July
{
    class Krishnamurthy_Number
    {
        static void Main(String[] args)
        {
            int num;

            int result = 0;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            int num1 = num;
            while (num > 0)
            {
                int temp = num % 10;
                int j=1;
                for(int i=temp;i>=1;i--)
                {
                     j = j * i;
                }
                result = result + j;
                num = num / 10;
            }
            Console.WriteLine(result);
            Console.WriteLine(num1);
            if (num1==result)
            {
                Console.WriteLine("Krishnamurthy Number:");
            }
            else
            {
                Console.WriteLine("Not a Krishnamurthy Number:");
            }

        }
    }
}
