using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_23July
{
    class Harshand_Number
    {
        static void Main(String[]args)
        {
            int num;
            
            int result = 0;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            int num1 = num;
            while (num>0)
            {
                int temp = num % 10;
                result = result + temp;
                num = num / 10;
            }
            Console.WriteLine(result);
            Console.WriteLine(num1);
            if (num1%result==0)
            {
                Console.WriteLine("Harshand Number:");
            }
            else
            {
                Console.WriteLine("Not a Harshand Number:");
            }
                
        }
    }
}
