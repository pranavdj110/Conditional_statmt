using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework
{
    class Prime_method
    {
        public bool Prime(int num)
        {
            bool isTrue = true;
            for (int i=2;i<num;i++)
            {
               
                if(num%i==0)
                {
                    isTrue= false;
                   // return isTrue;
                    break;

                }
             }
            
            if(isTrue==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class Program
    {
        static void Main(String[] args)
        {
            Prime_method p1 = new Prime_method();
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            bool b1=p1.Prime(num1);
            Console.WriteLine(b1);
            if(b1==true)
            {
                Console.WriteLine("The number is a Prime Number.");
            }
            else
            {
                Console.WriteLine("The number is not a Prime Number.");
            }
            
        }
    }
}
