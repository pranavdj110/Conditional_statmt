using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework
{
    class Even1to20
    {
        static void Main(String[] args)
        {
            int sum = 0;
            int count=0;
            for(int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            Console.WriteLine("Sum is:"+sum);
            Console.WriteLine("No of digit is:" + count);
            Console.WriteLine("Average is:"+(sum / count));
        }
    }
}
