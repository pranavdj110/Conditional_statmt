using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._22_Aug_2022
{
    class Program4       //Program to check whether entered email is valid or not.
    {
        static void Main(String[] args)
        {
            string mail = "abcdefg@gmail.com";
            if(mail.Contains('.')&& mail.Contains('@'))
            { 
               if(mail.IndexOf('.')> mail.IndexOf('@'))
                {
                   Console.WriteLine("valid Email");
                }
               else
                {
                    Console.WriteLine("Invalid Email");
                }
            
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
}
