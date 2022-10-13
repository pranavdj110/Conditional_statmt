using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework.Prorigo
{
    class Coprime
    {
        
            
        public bool Check_coprime(int num1, int num2)
        {
            bool flag = true; int count2 = 0; int count1 = 0;

            for (int i = num1 / 2; i >= 1; i--)
            {
                if (num1 % i == 0)
                {
                    count1++;
                }
            }
            for (int i = num2 / 2; i >= 1; i--)
            {
                if (num2 % i == 0)
                {
                    count2++;
                }
            }


            if (count1 > 1 && count2 > 1)
            {
                flag = false;
            }

            else
            {
                flag = true;
            }
            return flag;
        }

        public static void Main(String[] args)
        {
            Coprime cp = new Coprime();
            int n1 = 50; int n2 = 25;
            bool bn = cp.Check_coprime(n1, n2);
            if (bn == false)
            {
                Console.WriteLine("Not coprime");
            }
            else
            {
                Console.WriteLine(" coprime");
            }
        }
   }
        
    
}
