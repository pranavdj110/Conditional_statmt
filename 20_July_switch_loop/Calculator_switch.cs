using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._20_July_switch_loop
{
    class Calculator_switch
    {
        static void Main(String[] args)
        {
            char ch;
            int num1, num2;
            Console.WriteLine("Enter First Number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            num2 = int.Parse(Console.ReadLine());

           

            Console.WriteLine("Please enter your choice from below list:");
            Console.WriteLine("Enter + for Addition");
            Console.WriteLine("Enter - for Subtraction");
            Console.WriteLine("Enter * for Multiplicaion");
            Console.WriteLine("Enter / for Division");
            Console.WriteLine("Enter Your Choice:");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;

                default: Console.WriteLine("Invalid Choice");
                    break;






            }
        }
    }
}
