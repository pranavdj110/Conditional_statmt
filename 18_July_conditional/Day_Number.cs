using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt
{
    class Day_Number
    {
       public static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a Number");
            num = int.Parse(Console.ReadLine());
            if(num==1)
            {
                Console.WriteLine("The Day is Sunday");

            }
            else if(num==2)
            {
                Console.WriteLine("The Day is Monday");
            }
            else if (num == 3)
            {
                Console.WriteLine("The Day is Tuesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("The Day is Wednesday");
            }
            else if (num == 5)
            {
                Console.WriteLine("The Day is Thursday");
            }
            else if (num == 6)
            {
                Console.WriteLine("The Day is Friay");
            }
            else if (num == 7)
            {
                Console.WriteLine("The Day is Saturday");
            }
            else
            {
                Console.WriteLine("Invalid Day Number");
            }

        }
    }
}
