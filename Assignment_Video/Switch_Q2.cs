using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Assignment_Video
{
    class Switch_Q2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter number 1 to 5:");
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1: Console.WriteLine("One");
            break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default: Console.WriteLine("Invalid number.");
                    break;

            }
        }
    }
}
