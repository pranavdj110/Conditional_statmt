using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt
{
    class Teenager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your age?");
            int age = int.Parse(Console.ReadLine());
            if(age>=2 && age<=12)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Not a Teenager");
            }
        }
    }
}
