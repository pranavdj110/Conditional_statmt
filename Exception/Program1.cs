using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Exception
{
    class Program1
    {
        static void Main(String[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Please enter number");
            }

         for(int i = 0;i< 20; i++)
             {
                Console.WriteLine(i);
            }
        }
    }
}
