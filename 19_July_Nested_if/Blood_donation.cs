using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._19_July_Nested_if
{
    class Blood_donation
    {
        static void Main(String[]args)
        {
            int age;
            int weight;
            Console.WriteLine("Enter Age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight:");
            weight = int.Parse(Console.ReadLine());
            if(age>18)
            {
                if(weight>50)
                {
                    Console.WriteLine("You are Eligible for Blood Donation.");
                }
                else
                {
                    Console.WriteLine("You are not Eligible for Blood Donation.");
                }
            }
            else
            {
                Console.WriteLine("You are not Eligible for Blood Donation.");
            }
        }
    }
}
