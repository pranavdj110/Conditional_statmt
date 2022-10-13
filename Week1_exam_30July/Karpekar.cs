using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_30July
{
    class Karpekar
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int sqr = num * num;
            int count = 0;
            int sum = 0;
            int power = 1;
            int div;
           // int a = sqr % 100 + sqr / 10;
            while(num>0)
            {
               
                count++;
                num = num / 10;
                //count++;
            }
             
            for(int j=1;j<=count;j++)
            {
                power = power * 10;
            }
            div = sqr / power;
            int num3 = sqr % power;
            sum = div + num3;
            if(sum==num1)
            {
                Console.WriteLine("Karpekar");
            }
            else
            {
                Console.WriteLine("not Karpekar");
            }


        }
    }
}
