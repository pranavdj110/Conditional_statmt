using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework
{
    class IMEI
    {
        static void Main(String[]args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            int sum = 0;
            
             while(num>0)
            {
                int temp = num % 10;
                sum = sum + temp;
                num = num / 10;
            }
             if(sum%10==0)
            {
                Console.WriteLine("Correct IMEI number.");

            }
            else
            {
                Console.WriteLine("Inorrect IMEI number.");
            }
        }
        
    }
}
