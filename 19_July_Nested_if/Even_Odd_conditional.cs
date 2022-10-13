using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._19_July_Nested_if
{
    class Even_Odd_conditional
    {
        static void Main(String[]args)
        {
            int num;
            Console.WriteLine("Enter a Number:");
            num = int.Parse(Console.ReadLine());

            if(num%2==0)
            {
                if(num>5 && num<10)
                {
                    Console.WriteLine("Only Even");
                }
                else
                {
                    Console.WriteLine("Hi Even");
                }
            }
            else
            {
                if(num>2 && num<6)
                {
                    Console.WriteLine("Hello Odd");
                }
            }

        }
    }
}
