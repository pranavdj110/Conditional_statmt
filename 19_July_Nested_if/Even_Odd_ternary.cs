using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._19_July_Nested_if
{
    class Even_Odd_ternary
    {
        public static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
           
            string result = num % 2 == 0 ? "The Number is Even" : "The Number is Odd";
            Console.WriteLine(result);

        }

    }
}
