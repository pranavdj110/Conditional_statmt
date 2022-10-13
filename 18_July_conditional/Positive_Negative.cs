using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt
{
    class Positive_Negative
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a Number");
            num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("The Entered Numer is Postive");
            }
            else
            {

                Console.WriteLine("The Entered Numer is Negative");
            }

        }
    }
}
