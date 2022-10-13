using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._20_July_switch_loop
{
    class Day_number
    {
        static void Main(String[]args)
        {
            int num;
            Console.WriteLine("Enter a number between 1 to 7 ");
            num = int.Parse(Console.ReadLine());
            
            switch(num)
            {
                case 1:Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesay");
                    break;
                case 5:
                    Console.WriteLine("Tuesday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:Console.WriteLine("Invalid Number");
                    break;

            }
        }
    }
}
