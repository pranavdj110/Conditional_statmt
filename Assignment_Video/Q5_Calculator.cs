using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q5_Calculator
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
            if(ch=='+')
            {
                Console.WriteLine("Addition=" + (num1 + num2));
            }
            else if (ch == '+')
            {
                Console.WriteLine("Subtraction=" + (num1 - num2));
            }
            else if (ch == '-')
            {
                Console.WriteLine("Multiplication=" + (num1 * num2));
            }
           else if (ch == '*')
            {
                Console.WriteLine("Division=" + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
