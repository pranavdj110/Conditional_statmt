using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week7_exam
{
    class Q3
    {
        static void Main(String[] arg)
        {
            int num = 194;
            string snum = num.ToString();
            int num1 = num * 2;
            string snum1 = num1.ToString();
            int num2 = num * 3;
            string snum2 = num2.ToString();

            string number = snum + snum1 + snum2;
            Console.WriteLine(number);
            bool flag=true;
            int count = 0;
            for (int i = 0; i <= 9; i++)
            {
                
                for(int j = 0; j < number.Length; j++)
                {
                    if (i == number[j])
                    {
                        count++;
                        
                    }
                    
                }
                if (count > 1)
                {
                    flag = false;
                    break;
                }


            }
            if (flag == false)
            {
                Console.WriteLine("NOT FASCINATING");
            }
            else
            {
                Console.WriteLine(" FASCINATING");
            }
            

        }
    }
}
