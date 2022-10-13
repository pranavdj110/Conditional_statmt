using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._19_July_Nested_if
{
    class Positive_negative_zero_ternary
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());

            string result = num > 0 ? "The Number is positive" : num == 0 ? "The Number is zero" : "The Number is Negative";
            Console.WriteLine(result);
        }

    }
}
