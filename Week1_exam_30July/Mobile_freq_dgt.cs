using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_30July
{
    class Mobile_freq_dgt
    {
        static void Main(String[] args)
        {
            int zero = 0;int one = 0; int two = 0; int three = 0;int four = 0;int five = 0;int six = 0;int seven = 0;int eight = 0;int nine=0;
            // Console.WriteLine("Enter a mobile number:");
           // int num = int.Parse(Console.ReadLine());
            
            long num = 9089786754l;
            while(num>0)
            {
                long i = num % 10;
                if(i==0)
                {
                    zero++;
                }
                else if(i==1)
                {
                    one++;
                }
                else if (i == 2)
                {
                    two++;
                }
                else if (i == 3)
                {
                    three++;
                }
                else if (i == 4)
                {
                    four++;
                }
                else if (i == 5)
                {
                    five++;
                }
                else if (i == 6)
                {
                    six++;
                }
                else if (i == 7)
                {
                    seven++;
                }
                else if (i == 8)
                {
                    eight++;
                }
                else if (i == 9)
                {
                    nine++;
                }
                num = num / 10;

            }
            Console.WriteLine("Frequency of 0=" + zero);
            Console.WriteLine("Frequency of 1=" + one);
            Console.WriteLine("Frequency of 2=" + two);
            Console.WriteLine("Frequency of 3=" + three);
            Console.WriteLine("Frequency of 4=" + four);
            Console.WriteLine("Frequency of 5=" + five);
            Console.WriteLine("Frequency of 6=" + six);
            Console.WriteLine("Frequency of 7=" + seven);
            Console.WriteLine("Frequency of 8=" + eight);
            Console.WriteLine("Frequency of 9=" + nine);
        }
    }
}
