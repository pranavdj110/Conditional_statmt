using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q7
    {
        static void Main(string[] args)
        {
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch>='a'&&ch<='z'|| ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Character.");
            }
            else if(ch>='0'&&ch<='9')
            {
                Console.WriteLine("Digit.");
            }
            else
            {
                Console.WriteLine("Special Character.");
            }
        }
    }
}
