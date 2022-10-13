using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._21_July_doWhile
{
    class Armstrong
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            int num1 = num;
            int sum = 0;
           
            while(num>0)
            {
                int n=num % 10;
                sum = sum + n*n*n;
                   
                num = num/10;
            }
            Console.WriteLine(sum);
            //Console.WriteLine(num);


            if (num1==sum)
             {
                 Console.WriteLine("Armstrong");
             }
             else
             {
                 Console.WriteLine("Not Armstrong");
             }
             

        }
    }
}
