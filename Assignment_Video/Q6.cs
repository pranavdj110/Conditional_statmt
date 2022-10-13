using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q6
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a Number");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("The Entered Numer is Postive");
            }
            else if (num < 0)
            {
                Console.WriteLine("The Entered Numer is Negative");
            }
            else if (num == 0)
            {
                Console.WriteLine("The Entered Numer is Zero");
            }
        }
    }
}
