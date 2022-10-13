using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Q13
    {
        static void Main(String[] args)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for(int i = 0; i <= 50; i++)
            {
                if(i%5==0 && i % 3 == 0)
                {
                    Console.WriteLine("BuzzFizz");
                    count1++;
                }
                else if ( i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                    count2++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                    count3++;
                }

            }

            Console.WriteLine("BuzzFizz:"+count1);
            Console.WriteLine("Buzz" + count2);
            Console.WriteLine("Fizz:" + count3);

        }
    }
}
