using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework.Prorigo
{
    class Arithmatic_pg
    {
        public int A_progresn(int num,int num1,int n)
        {
            int d;
            if (num1 > num)
                d = num1 - num;
            else
                d = num - num1;


            while (num1 >= 0)
            {
                num1 = num1 - d;
            }


            int a = num1 + d;                    //first term    
            //Console.WriteLine(a);


            int req_num = a + (n - 1) * d;
            return req_num;
            //Console.WriteLine("nth term:" + req_num);
        }

        static void Main(String[] args)
        {
            int n1 = 21; int n2 = 27; 
            int n = 19;          
            Arithmatic_pg a = new Arithmatic_pg();
            int num = a.A_progresn(n1, n2, n);

            Console.WriteLine(n + "th term:" + num);
        }
    }
}
