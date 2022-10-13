using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._04Aug_2022
{
    class Fahrenheit
    {
        static void Main(String[] args)
        {
            float celcius;
            Console.WriteLine("Enter temprature in Fahrenheit:");

            float farenht=float.Parse(Console.ReadLine());
            celcius = (farenht - 32) * (5 / 9);
            Console.WriteLine("Enter temprature in Celcius:"+celcius);
        }
    }
}
